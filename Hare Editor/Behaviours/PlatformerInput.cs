using HareEngine;
using OpenTK;

namespace HareEditor {

    public class PlatformerInput : Behaviour {

        public float Speed;
        private Rigidbody rb;

        public PlatformerInput(GameObject gameObject) : base(gameObject) {
            Speed = 3.14159f;
            rb = GetComponent<Rigidbody>();
        }

        public override void Update() {
            if (rb != null) {

                if (transform.position.Y < 0f) {
                    transform.position.Y = 0f;
                    rb.speed.Y = 0f;
                }

                if (Input.GetButton(OpenTK.Input.Key.Left) || Input.GetButton(OpenTK.Input.Key.A)) {
                    rb.Translate(-(Speed * Time.deltaTime * Time.timeScale), 0f);
                    transform.scale.X = -Mathf.Abs(transform.scale.X);
                }

                if (Input.GetButton(OpenTK.Input.Key.Right) || Input.GetButton(OpenTK.Input.Key.D)) {
                    rb.Translate(Speed * Time.deltaTime * Time.timeScale, 0f);
                    transform.scale.X = Mathf.Abs(transform.scale.X);
                }

                if (Input.GetButtonDown(OpenTK.Input.Key.Space) || Input.GetButtonDown(OpenTK.Input.Key.W)) {
                    rb.AddForce(0f, 32f, 0f);
                }
            }
        }


    }

}
