/** Copyright (c) 2017 Samsung Electronics Co., Ltd.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

namespace Tizen.NUI
{

    public class Shader : Animatable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal Shader(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.Shader_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Shader obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        protected override void Dispose(DisposeTypes type)
        {
            if (disposed)
            {
                return;
            }

            if (type == DisposeTypes.Explicit)
            {
                //Called by User
                //Release your own managed resources here.
                //You should release all of your own disposable objects here.

            }

            //Release your own unmanaged resources here.
            //You should not access any managed member here except static instance.
            //because the execution order of Finalizes is non-deterministic.

            if (swigCPtr.Handle != global::System.IntPtr.Zero)
            {
                if (swigCMemOwn)
                {
                    swigCMemOwn = false;
                    NDalicPINVOKE.delete_Shader(swigCPtr);
                }
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
            }

            base.Dispose(type);
        }


        public class Hint
        {
            public enum Value
            {
                NONE = 0x00,
                OUTPUT_IS_TRANSPARENT = 0x01,
                MODIFIES_GEOMETRY = 0x02
            }
        }

        public class Property
        {
            public static readonly int PROGRAM = NDalicPINVOKE.Shader_Property_PROGRAM_get();
        }

        public Shader(string vertexShader, string fragmentShader, Shader.Hint.Value hints) : this(NDalicPINVOKE.Shader_New__SWIG_0(vertexShader, fragmentShader, (int)hints), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

        }
        public Shader(string vertexShader, string fragmentShader) : this(NDalicPINVOKE.Shader_New__SWIG_1(vertexShader, fragmentShader), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

        }

        public Tizen.NUI.PropertyMap Program
        {
            get
            {
                Tizen.NUI.PropertyMap temp = new Tizen.NUI.PropertyMap();
                Tizen.NUI.Object.GetProperty(swigCPtr, Shader.Property.PROGRAM).Get(temp);
                return temp;
            }
            set
            {
                Tizen.NUI.Object.SetProperty(swigCPtr, Shader.Property.PROGRAM, new Tizen.NUI.PropertyValue(value));
            }
        }
    }

}