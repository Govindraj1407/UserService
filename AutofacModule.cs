// <copyright file="AutofacModule.cs" company="Trane Company">
// Copyright (c) Trane Company. All rights reserved.
// </copyright>

namespace UserService.Configurations
{
    using Autofac;
    using UserService.Services;

    /// <summary>
    /// Module for configuring dependency injection
    /// </summary>
    public class AutofacModule : Autofac.Module
   {

      /// <summary>
      /// Initializes a new instance of the <see cref="AutofacModule"/> class.
      /// </summary>
      public AutofacModule()
      {
      }

      /// <summary>
      /// Load the dependencies
      /// </summary>
      /// <param name="builder">builder</param>
      protected override void Load(ContainerBuilder builder)
      {        
         builder.RegisterType(typeof(UserService)).As(typeof(IUserService));         
      }
   }
}
