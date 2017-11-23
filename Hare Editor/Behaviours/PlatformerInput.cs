using HareEngine;
using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Vector3 moveSpeed = new Vector3();



                rb.AddForce(moveSpeed);
            }
        }


    }

}
