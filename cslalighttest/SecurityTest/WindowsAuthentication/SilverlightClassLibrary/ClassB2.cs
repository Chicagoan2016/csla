﻿using System;
using System.Net;
using Csla;
using Csla.Security;
using Csla.Serialization;

namespace ClassLibrary
{
  [Serializable()]
  public class ClassB2 : BusinessBase<ClassB2>
  {
    private static PropertyInfo<string> AProperty = RegisterProperty(new PropertyInfo<string>("A"));
    public string A
    {
      get { return GetProperty<string>(AProperty); }
      set { SetProperty<string>(AProperty, value); }
    }
    private static PropertyInfo<string> BProperty = RegisterProperty(new PropertyInfo<string>("B"));
    public string B
    {
      get { return GetProperty<string>(BProperty); }
      set { SetProperty<string>(BProperty, value); }
    }

    protected override void AddAuthorizationRules()
    {
      AuthorizationRules.AllowWrite(AProperty, "invalid");
      AuthorizationRules.AllowRead(AProperty, "invalid");
    }

    protected static void AddObjectAuthorizationRules()
    {
      AuthorizationRules.AllowCreate(typeof(ClassB2), "Users");
      AuthorizationRules.AllowEdit(typeof(ClassB2), "Users");
      AuthorizationRules.AllowDelete(typeof(ClassB2), "Users");
    }
  }
}
