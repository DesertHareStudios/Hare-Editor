using System.Windows.Forms;
using System.Collections.Generic;
using HareEngine;
using System.Reflection;
using System;

namespace HareEditor {

    public class Inspector : DBPanel {

        private List<Control> toAdd = new List<Control>();

        public void Reload() {
            Controls.Clear();
            if (Program.editor.SelectedGameObject != null) {
                StringField name = new StringField();
                StringField tag = new StringField();
                VectorField position = new VectorField();
                QuaternionField rotation = new QuaternionField();
                VectorField scale = new VectorField();

                name.Dock = DockStyle.Top;
                name.Value = Program.editor.SelectedGameObject.Name;
                name.FontColor = Program.colorFont;
                name.Text = "Name";
                name.ValueChanged += (o, e) => {
                    Program.editor.SelectedGameObject.Name = name.Value;
                    Program.editor.Hierarchy.Reload();
                };

                tag.Dock = DockStyle.Top;
                tag.Value = Program.editor.SelectedGameObject.Tag;
                tag.FontColor = Program.colorFont;
                tag.Text = "Tag";
                tag.ValueChanged += (o, e) => {
                    Program.editor.SelectedGameObject.Tag = tag.Value;
                };

                position.Dock = DockStyle.Top;
                position.Text = "Position";
                position.FontColor = Program.colorFont;
                position.Value = Program.editor.SelectedGameObject.transform.position;
                position.ValueChanged += (o, e) => {
                    Program.editor.SelectedGameObject.transform.position = position.Value;
                };

                rotation.Dock = DockStyle.Top;
                rotation.Text = "Rotation";
                rotation.FontColor = Program.colorFont;
                rotation.Value = Program.editor.SelectedGameObject.transform.rotation;
                rotation.ValueChanged += (o, e) => {
                    Program.editor.SelectedGameObject.transform.rotation = rotation.Value;
                };

                scale.Dock = DockStyle.Top;
                scale.Text = "Scale";
                scale.FontColor = Program.colorFont;
                scale.Value = Program.editor.SelectedGameObject.transform.scale;
                scale.ValueChanged += (o, e) => {
                    Program.editor.SelectedGameObject.transform.scale = scale.Value;
                };

                toAdd.Add(name);
                toAdd.Add(tag);
                toAdd.Add(position);
                toAdd.Add(rotation);
                toAdd.Add(scale);
                PrintBehaviours();
            }

            for (int i = toAdd.Count - 1; i >= 0; i--) {
                Controls.Add(toAdd[i]);
            }
            toAdd.Clear();
        }

        private void PrintBehaviours() {
            if (Program.editor.SelectedGameObject != null) {
                foreach (Behaviour b in Program.editor.SelectedGameObject.behaviours) {
                    //Label label = new Label();
                    //label.Text = b.GetType().Name;
                    //label.ForeColor = Program.colorAccentFont;
                    //label.BackColor = Program.colorAccent;
                    //label.Dock = DockStyle.Top;
                    //label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    //label.Height = 24;

                    BehaviourField bf = new BehaviourField();
                    bf.Text = b.GetType().Name;
                    bf.FontColor = Program.colorAccentFont;
                    bf.BackColor = Program.colorAccentDark;
                    bf.Dock = DockStyle.Top;
                    bf.Active = b.Active;
                    bf.ActiveChanged += (active) => {
                        b.Active = active;
                    };
                    bf.Delete += () => {
                        if (DialogResult.Yes == MessageBox.Show(
                                "Are you sure you want to remove this behaviour?",
                                "Removing " + b.GetType().Name,
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question
                            )) {
                            Program.editor.SelectedGameObject.behaviours.Remove(b);
                            Reload();
                        }
                    };

                    toAdd.Add(bf);
                    foreach (FieldInfo prop in b.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public)) {
                        try {
                            TypeSwitch ts = new TypeSwitch()
                                .Case<string>(() => {
                                    StringField panel = new StringField();
                                    panel.Dock = DockStyle.Top;
                                    panel.Text = prop.Name;
                                    panel.Value = (string)prop.GetValue(b);
                                    panel.FontColor = Program.colorFont;
                                    panel.ValueChanged += (o, e) => {
                                        prop.SetValue(b, panel.Value);
                                    };
                                    toAdd.Add(panel);
                                })
                                .Case<int>(() => {
                                    NumberField panel = new NumberField();
                                    panel.Dock = DockStyle.Top;
                                    panel.Text = prop.Name;
                                    panel.Value = (int)prop.GetValue(b);
                                    panel.FontColor = Program.colorFont;
                                    panel.ValueChanged += (o, e) => {
                                        prop.SetValue(b, (int)panel.Value);
                                    };
                                    toAdd.Add(panel);
                                })
                                .Case<float>(() => {
                                    NumberField panel = new NumberField();
                                    panel.Dock = DockStyle.Top;
                                    panel.Text = prop.Name;
                                    panel.Value = (decimal)(float)prop.GetValue(b);
                                    panel.FontColor = Program.colorFont;
                                    panel.ValueChanged += (o, e) => {
                                        prop.SetValue(b, (float)panel.Value);
                                    };
                                    toAdd.Add(panel);
                                })
                                .Case<double>(() => {
                                    NumberField panel = new NumberField();
                                    panel.Dock = DockStyle.Top;
                                    panel.Text = prop.Name;
                                    panel.Value = (decimal)(double)prop.GetValue(b);
                                    panel.FontColor = Program.colorFont;
                                    panel.ValueChanged += (o, e) => {
                                        prop.SetValue(b, (double)panel.Value);
                                    };
                                    toAdd.Add(panel);
                                })
                                .Case<bool>(() => {
                                    DBPanel panel = new DBPanel();
                                    panel.Dock = DockStyle.Top;
                                    panel.Height = 24;
                                    CheckBox cbxValue = new CheckBox();
                                    panel.Controls.Add(cbxValue);
                                    cbxValue.Text = prop.Name;
                                    cbxValue.Checked = (bool)prop.GetValue(b);
                                    cbxValue.AutoSize = false;
                                    cbxValue.Dock = DockStyle.Fill;
                                    cbxValue.ForeColor = Program.colorFont;
                                    cbxValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                                    cbxValue.Dock = DockStyle.Left;
                                    cbxValue.CheckedChanged += (o, e) => {
                                        prop.SetValue(b, cbxValue.Checked);
                                    };
                                    toAdd.Add(panel);
                                })
                                .Case<Color>(() => {
                                    ColorField panel = new ColorField();
                                    panel.Dock = DockStyle.Top;
                                    panel.Text = prop.Name;
                                    panel.FontColor = Program.colorFont;
                                    panel.Color = Program.HareColorToNETColor((Color)prop.GetValue(b));
                                    panel.Click += (o, e) => {
                                        ColorSelector.Prompt(panel.Text, panel.Color, (color) => {
                                            prop.SetValue(b, color);
                                            panel.Color = Program.HareColorToNETColor(color);
                                        });
                                    };
                                    toAdd.Add(panel);
                                })
                                .Case<HareEngine.Texture>(() => {
                                    TextureField panel = new TextureField();
                                    panel.Dock = DockStyle.Top;
                                    panel.Text = prop.Name;
                                    panel.FontColor = Program.colorFont;
                                    panel.Texture = ((Texture)prop.GetValue(b)).FilePath;
                                    panel.Click += (o, e) => {
                                        ImagePrompt.Prompt(panel.Text, (tex) => {
                                            Texture texture = HareEngine.Asset.Get<Texture>(tex);
                                            if (texture != null) {
                                                prop.SetValue(b, texture);
                                                panel.Texture = texture.FilePath;
                                            } else {
                                                MessageBox.Show(tex);
                                            }
                                        });
                                    };
                                    toAdd.Add(panel);
                                })
                                .Case<OpenTK.Vector3>(() => {
                                    VectorField panel = new VectorField();
                                    panel.Dock = DockStyle.Top;
                                    panel.Text = prop.Name;
                                    panel.FontColor = Program.colorFont;
                                    panel.Value = (OpenTK.Vector3)prop.GetValue(b);
                                    panel.ValueChanged += (o, e) => {
                                        prop.SetValue(b, panel.Value);
                                    };
                                    toAdd.Add(panel);
                                })
                                .Case<OpenTK.Quaternion>(() => {
                                    QuaternionField panel = new QuaternionField();
                                    panel.Dock = DockStyle.Top;
                                    panel.Text = prop.Name;
                                    panel.FontColor = Program.colorFont;
                                    panel.Value = (OpenTK.Quaternion)prop.GetValue(b);
                                    panel.ValueChanged += (o, e) => {
                                        prop.SetValue(b, panel.Value);
                                    };
                                    toAdd.Add(panel);
                                })
                                .Case<Range>(() => {
                                    RangedNumberField panel = new RangedNumberField((Range)prop.GetValue(b));
                                    panel.Dock = DockStyle.Top;
                                    panel.Text = prop.Name;
                                    panel.Value = (float)((Range)prop.GetValue(b)).Value;
                                    panel.FontColor = Program.colorFont;
                                    panel.ValueChanged += (o, e) => {
                                        ((Range)prop.GetValue(b)).Value = (float)(panel.Value);
                                    };
                                    toAdd.Add(panel);
                                })
                                .Default(() => {
                                    //TODO handle different types
                                    if (prop.GetValue(b).GetType().IsEnum) {
                                        EnumField panel = new EnumField(prop.GetValue(b).GetType());
                                        panel.Dock = DockStyle.Top;
                                        panel.Text = prop.Name;
                                        panel.Value = prop.GetValue(b);
                                        panel.FontColor = Program.colorFont;
                                        panel.ValueChanged += (o, e) => {
                                            try {
                                                prop.SetValue(b, panel.Value);
                                            } catch (Exception ex) {
                                                Debug.Exception(ex);
                                            }
                                        };
                                        toAdd.Add(panel);
                                    }
                                });
                            ts.Switch(prop.GetValue(b).GetType());
                        } catch (Exception e) {
                            if (prop.GetValue(b) != null) {
                                Debug.Exception(e);
                            }
                        }
                    }
                }
            }
        }

    }

}
