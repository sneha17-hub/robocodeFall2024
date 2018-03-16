/**
 * Copyright (c) 2001-2018 Mathew A. Nelson and Robocode contributors
 * All rights reserved. This program and the accompanying materials
 * are made available under the terms of the Eclipse Public License v1.0
 * which accompanies this distribution, and is available at
 * http://robocode.sourceforge.net/license/epl-v10.html
 */
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.8669
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace robocode.control {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class RobotResults : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getRobot0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_convertResults1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorRobotResults2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorRobotResults3;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/control/RobotSpecification;Ljava/lang/String;IDDDDDDDIII)V")]
        public RobotResults(global::robocode.control.RobotSpecification par0, global::java.lang.String par1, int par2, double par3, double par4, double par5, double par6, double par7, double par8, double par9, int par10, int par11, int par12) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 36)){
            @__env.NewObject(global::robocode.control.RobotResults.staticClass, global::robocode.control.RobotResults.j4n__ctorRobotResults2, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par9), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par10), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par11), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par12));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/control/RobotSpecification;Lrobocode/BattleResults;)V")]
        public RobotResults(global::robocode.control.RobotSpecification par0, global::java.lang.Object par1) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.NewObject(global::robocode.control.RobotResults.staticClass, global::robocode.control.RobotResults.j4n__ctorRobotResults3, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1));
            }
        }
        
        protected RobotResults(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::robocode.control.RobotResults.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::robocode.control.RobotResults.staticClass = @__class;
            global::robocode.control.RobotResults.j4n_getRobot0 = @__env.GetMethodID(global::robocode.control.RobotResults.staticClass, "getRobot", "()Lrobocode/control/RobotSpecification;");
            global::robocode.control.RobotResults.j4n_convertResults1 = @__env.GetStaticMethodID(global::robocode.control.RobotResults.staticClass, "convertResults", "([Lrobocode/BattleResults;)[Lrobocode/control/RobotResults;");
            global::robocode.control.RobotResults.j4n__ctorRobotResults2 = @__env.GetMethodID(global::robocode.control.RobotResults.staticClass, "<init>", "(Lrobocode/control/RobotSpecification;Ljava/lang/String;IDDDDDDDIII)V");
            global::robocode.control.RobotResults.j4n__ctorRobotResults3 = @__env.GetMethodID(global::robocode.control.RobotResults.staticClass, "<init>", "(Lrobocode/control/RobotSpecification;Lrobocode/BattleResults;)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Lrobocode/control/RobotSpecification;")]
        public virtual global::robocode.control.RobotSpecification getRobot() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::robocode.control.RobotSpecification>(@__env, @__env.CallObjectMethodPtr(this, global::robocode.control.RobotResults.j4n_getRobot0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([Lrobocode/BattleResults;)[Lrobocode/control/RobotResults;")]
        public static robocode.control.RobotResults[] convertResults(java.lang.Object[] par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2Cp<robocode.control.RobotResults[], global::robocode.control.RobotResults>(@__env, @__env.CallStaticObjectMethodPtr(global::robocode.control.RobotResults.staticClass, global::robocode.control.RobotResults.j4n_convertResults1, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, par0)));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::robocode.control.RobotResults(@__env);
            }
        }
    }
    #endregion
}
