﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using TelChina.AF.Persistant;
using System.Runtime.Serialization;
using TelChina.AF.Sys.Serialization;

namespace TelChina.AF.Demo
{
    [DataContract(Namespace = @"http://schemas.telchina.org/2013/2/Entity", Name = "Answer")]
    [DataContractResolverAttribute(TypeAssembly = "TelChina.AF.Demo.DemoSV.Contract",
       TypeFullName = "TelChina.AF.Demo.AnswerDTO")]
    [Serializable]
    public partial class Answer : EntityBase
    {
        private String _name;

        private Guid? _question_ID;
        [DataMember(Order = 0)]
        public virtual String Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (this._name != value)
                {
                    RaisPropertyChangIngEvent("Name");
                    _name = value;
                    RaisPropertyChangedEvent("Name");
                }
            }
        }

        public virtual Guid? Question_ID
        {
            get
            {
                return this._question_ID;
            }
            set
            {
                if (this._question_ID != value)
                {
                    RaisPropertyChangIngEvent("Question_ID");
                    _question_ID = value;
                    RaisPropertyChangedEvent("Question_ID");
                }
            }
        }


        private string entityComponet;

        public override string EntityComponent
        {
            get
            {
                return entityComponet;
            }
            set
            {
                this.entityComponet = value;
            }
        }

        private Question _xxx;
        //[DataMember(Order = 1, Name = "Question")]
        public virtual Question Question
        {
            get { return _xxx; }
            set { _xxx = value; }
        }
    }
}


