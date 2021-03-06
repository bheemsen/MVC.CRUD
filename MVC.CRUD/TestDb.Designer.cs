﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace MVC.CRUD
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class TestDbEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new TestDbEntities object using the connection string found in the 'TestDbEntities' section of the application configuration file.
        /// </summary>
        public TestDbEntities() : base("name=TestDbEntities", "TestDbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new TestDbEntities object.
        /// </summary>
        public TestDbEntities(string connectionString) : base(connectionString, "TestDbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new TestDbEntities object.
        /// </summary>
        public TestDbEntities(EntityConnection connection) : base(connection, "TestDbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<TblTest> TblTests
        {
            get
            {
                if ((_TblTests == null))
                {
                    _TblTests = base.CreateObjectSet<TblTest>("TblTests");
                }
                return _TblTests;
            }
        }
        private ObjectSet<TblTest> _TblTests;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the TblTests EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTblTests(TblTest tblTest)
        {
            base.AddObject("TblTests", tblTest);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TestDbModel", Name="TblTest")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TblTest : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new TblTest object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        public static TblTest CreateTblTest(global::System.Int32 id)
        {
            TblTest tblTest = new TblTest();
            tblTest.ID = id;
            return tblTest;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Address
        {
            get
            {
                return _Address;
            }
            set
            {
                OnAddressChanging(value);
                ReportPropertyChanging("Address");
                _Address = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Address");
                OnAddressChanged();
            }
        }
        private global::System.String _Address;
        partial void OnAddressChanging(global::System.String value);
        partial void OnAddressChanged();

        #endregion

    
    }

    #endregion

    
}
