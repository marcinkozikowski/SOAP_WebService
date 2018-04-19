﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="HelloWorldImplPortBinding", Namespace="http://rsi.jg.org/")]
public partial class HelloWorldImplService : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private System.Threading.SendOrPostCallback getProductsOperationCompleted;
    
    private System.Threading.SendOrPostCallback getHelloWorldAsStringOperationCompleted;
    
    /// <remarks/>
    public HelloWorldImplService() {
        this.Url = "http://localhost:8080/WebServiceGlass/HelloWorldImplService";
    }
    
    /// <remarks/>
    public event getProductsCompletedEventHandler getProductsCompleted;
    
    /// <remarks/>
    public event getHelloWorldAsStringCompletedEventHandler getHelloWorldAsStringCompleted;
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://rsi.jg.org/", ResponseNamespace="http://rsi.jg.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public product[] getProducts() {
        object[] results = this.Invoke("getProducts", new object[0]);
        return ((product[])(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BegingetProducts(System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("getProducts", new object[0], callback, asyncState);
    }
    
    /// <remarks/>
    public product[] EndgetProducts(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((product[])(results[0]));
    }
    
    /// <remarks/>
    public void getProductsAsync() {
        this.getProductsAsync(null);
    }
    
    /// <remarks/>
    public void getProductsAsync(object userState) {
        if ((this.getProductsOperationCompleted == null)) {
            this.getProductsOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetProductsOperationCompleted);
        }
        this.InvokeAsync("getProducts", new object[0], this.getProductsOperationCompleted, userState);
    }
    
    private void OngetProductsOperationCompleted(object arg) {
        if ((this.getProductsCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.getProductsCompleted(this, new getProductsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://rsi.jg.org/", ResponseNamespace="http://rsi.jg.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string getHelloWorldAsString([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0) {
        object[] results = this.Invoke("getHelloWorldAsString", new object[] {
                    arg0});
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BegingetHelloWorldAsString(string arg0, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("getHelloWorldAsString", new object[] {
                    arg0}, callback, asyncState);
    }
    
    /// <remarks/>
    public string EndgetHelloWorldAsString(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void getHelloWorldAsStringAsync(string arg0) {
        this.getHelloWorldAsStringAsync(arg0, null);
    }
    
    /// <remarks/>
    public void getHelloWorldAsStringAsync(string arg0, object userState) {
        if ((this.getHelloWorldAsStringOperationCompleted == null)) {
            this.getHelloWorldAsStringOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetHelloWorldAsStringOperationCompleted);
        }
        this.InvokeAsync("getHelloWorldAsString", new object[] {
                    arg0}, this.getHelloWorldAsStringOperationCompleted, userState);
    }
    
    private void OngetHelloWorldAsStringOperationCompleted(object arg) {
        if ((this.getHelloWorldAsStringCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.getHelloWorldAsStringCompleted(this, new getHelloWorldAsStringCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    public new void CancelAsync(object userState) {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://rsi.jg.org/")]
public partial class product {
    
    private int cenaField;
    
    private string nazwaField;
    
    private string opisField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int cena {
        get {
            return this.cenaField;
        }
        set {
            this.cenaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string nazwa {
        get {
            return this.nazwaField;
        }
        set {
            this.nazwaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string opis {
        get {
            return this.opisField;
        }
        set {
            this.opisField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void getProductsCompletedEventHandler(object sender, getProductsCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class getProductsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal getProductsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public product[] Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((product[])(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void getHelloWorldAsStringCompletedEventHandler(object sender, getHelloWorldAsStringCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class getHelloWorldAsStringCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal getHelloWorldAsStringCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public string Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}