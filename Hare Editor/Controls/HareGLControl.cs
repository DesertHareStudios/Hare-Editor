using System;
using System.Collections.Generic;
using HareEngine;
using OpenTK;
using OpenTK.Input;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

public class HareGLControl : GLControl {

    private bool init = false;
    private Scene _currentScene;
    public Scene currentScene {
        get {
            return _currentScene;
        }
        set {
            _currentScene = value;
            init = true;
            //TODO do more changes
        }
    }
    private List<Key> keysd = new List<Key>();
    private List<Key> keysu = new List<Key>();
    private List<MouseButton> mbd = new List<MouseButton>();
    private List<MouseButton> mbu = new List<MouseButton>();

    public HareGLControl() : base(GraphicsMode.Default, 3, 0, GraphicsContextFlags.ForwardCompatible) {

    }

    public float AspectRatio {
        get {
            return (float)Width / (float)Height;
        }
    }

    protected override void OnLoad(EventArgs e) {
        base.OnLoad(e);
        GL.Enable(EnableCap.Blend);
        KeyUp += OnKeyUp;
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);
        GL.Viewport(Location.X, Location.Y, Width, Height);
    }

    protected void OnUpdateFrame(FrameEventArgs e) {
        Time.fixedDeltaTime = (float)e.Time;
        if (currentScene != null) {
            currentScene.FixedUpdate();
        }
    }

    protected void OnRenderFrame(FrameEventArgs e) {
        foreach (Key k in keysd) {
            Input.keysd.Add(k);
        }
        foreach (Key k in keysu) {
            Input.keysu.Add(k);
        }
        foreach (MouseButton mb in mbd) {
            Input.mbd.Add(mb);
        }
        foreach (MouseButton mb in mbu) {
            Input.mbu.Add(mb);
        }
        keysd.Clear();
        keysu.Clear();
        mbd.Clear();
        mbu.Clear();
        Time.deltaTime = (float)e.Time;
        Time.time += Time.deltaTime;
        float dump = HareEngine.Random.Value;
        GL.ClearColor(Hare.clearColor.r, Hare.clearColor.g, Hare.clearColor.b, Hare.clearColor.a);
        GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
        if (currentScene != null) {
            if (init) {
                init = false;
                currentScene.Preload?.Invoke();
                currentScene.Awake();
                currentScene.Start();
            }
            currentScene.Update();
            currentScene.LateUpdate();
            currentScene.Render();
        }
        this.SwapBuffers();
        Input.keysd.Clear();
        Input.keysu.Clear();
        Input.mb.Clear();
        Input.mbd.Clear();
        Input.mbu.Clear();
    }

    protected void OnMouseDown(MouseButtonEventArgs e) {
        Input.mb.Add(e.Button);
        mbd.Add(e.Button);
    }

    protected override void OnMouseEnter(EventArgs e) {
        base.OnMouseEnter(e);
        Input.isMouseInside = true;
    }

    protected override void OnMouseLeave(EventArgs e) {
        base.OnMouseLeave(e);
        Input.isMouseInside = false;
    }

    protected void OnMouseMove(MouseMoveEventArgs e) {
        Input.mousePosition = new Vector2(e.Position.X, e.Position.Y);
    }

    protected void OnMouseUp(MouseButtonEventArgs e) {
        Input.mb.Remove(e.Button);
        mbu.Add(e.Button);
    }

    protected void OnMouseWheel(MouseWheelEventArgs e) {
        Input.scrollDelta = e.DeltaPrecise;
    }

    protected void OnKeyDown(KeyboardKeyEventArgs e) {
        Input.keys.Add(e.Key);
        keysd.Add(e.Key);
    }

    protected void OnKeyUp(KeyboardKeyEventArgs e) {
        Input.keys.Remove(e.Key);
        keysu.Add(e.Key);
    }

}