using System;
using System.Collections.Generic;

namespace HareEditor {

    public class TypeSwitch {

        Dictionary<Type, Action> matches = new Dictionary<Type, Action>();
        Action def;

        public TypeSwitch Case<T>(Action action) {
            matches.Add(typeof(T), action);
            return this;
        }

        public TypeSwitch Default(Action action) {
            def = action;
            return this;
        }

        public void Switch(Type x) {
            if (matches.ContainsKey(x)) {
                matches[x]?.Invoke();
            } else {
                def?.Invoke();
            }
        }
    }

}
