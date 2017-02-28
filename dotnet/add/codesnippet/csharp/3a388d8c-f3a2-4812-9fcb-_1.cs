      // Define a public class named "HelloWorld" in the assembly.
      TypeBuilder helloWorldTypeBuilder = myModule.DefineType("HelloWorld", TypeAttributes.Public);
      // Define a private String field named "m_greeting" in "HelloWorld" class.
      FieldBuilder greetingFieldBuilder = helloWorldTypeBuilder.DefineField("m_greeting",
                                                typeof(String), FieldAttributes.Private);
      // Create constructor args and define constructor.
      Type[] constructorArgs = { typeof(String) };
      ConstructorBuilder constructor = helloWorldTypeBuilder.DefineConstructor(
         MethodAttributes.Public, CallingConventions.Standard, constructorArgs);

      // Generate IL code for the method.The constructor stores its argument in the private field.
      ILGenerator constructorIL = constructor.GetILGenerator();
      constructorIL.Emit(OpCodes.Ldarg_0);
      constructorIL.Emit(OpCodes.Ldarg_1);
      constructorIL.Emit(OpCodes.Stfld, greetingFieldBuilder);
      constructorIL.Emit(OpCodes.Ret);
      // Define property Greeting.
      PropertyBuilder greetingPropertyBuilder = helloWorldTypeBuilder.DefineProperty(
                               "Greeting",PropertyAttributes.None,typeof(string),null);

      // Define the 'get_Greeting' method.
      MethodBuilder getGreetingMethod = helloWorldTypeBuilder.DefineMethod("get_Greeting",
         MethodAttributes.Public|MethodAttributes.HideBySig|MethodAttributes.SpecialName,
         typeof(String),null);
      // Generate IL code for 'get_Greeting' method.
      ILGenerator methodIL = getGreetingMethod.GetILGenerator();
      methodIL.Emit(OpCodes.Ldarg_0);
      methodIL.Emit(OpCodes.Ldfld, greetingFieldBuilder);
      methodIL.Emit(OpCodes.Ret);
      greetingPropertyBuilder.SetGetMethod(getGreetingMethod);

      // Define the set_Greeting method.
      Type[] methodArgs = {typeof(string)};
      MethodBuilder setGreetingMethod = helloWorldTypeBuilder.DefineMethod("set_Greeting",
         MethodAttributes.Public|MethodAttributes.HideBySig|MethodAttributes.SpecialName,
         typeof(void), methodArgs);
      // Generate IL code for set_Greeting method.
      methodIL = setGreetingMethod.GetILGenerator();
      methodIL.Emit(OpCodes.Ldarg_0);
      methodIL.Emit(OpCodes.Ldarg_1);
      methodIL.Emit(OpCodes.Stfld,greetingFieldBuilder);
      methodIL.Emit(OpCodes.Ret);
      greetingPropertyBuilder.SetSetMethod(setGreetingMethod);