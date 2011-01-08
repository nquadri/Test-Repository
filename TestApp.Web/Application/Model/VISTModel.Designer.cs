﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace TestApp.Web.Application.Model
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class VISTEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new VISTEntities object using the connection string found in the 'VISTEntities' section of the application configuration file.
        /// </summary>
        public VISTEntities() : base("name=VISTEntities", "VISTEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new VISTEntities object.
        /// </summary>
        public VISTEntities(string connectionString) : base(connectionString, "VISTEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new VISTEntities object.
        /// </summary>
        public VISTEntities(EntityConnection connection) : base(connection, "VISTEntities")
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
        public ObjectSet<Voter> Voters
        {
            get
            {
                if ((_Voters == null))
                {
                    _Voters = base.CreateObjectSet<Voter>("Voters");
                }
                return _Voters;
            }
        }
        private ObjectSet<Voter> _Voters;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Voters EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToVoters(Voter voter)
        {
            base.AddObject("Voters", voter);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="VISTModel", Name="Voter")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Voter : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Voter object.
        /// </summary>
        /// <param name="certnum">Initial value of the Certnum property.</param>
        /// <param name="lastName">Initial value of the LastName property.</param>
        /// <param name="firstName">Initial value of the FirstName property.</param>
        public static Voter CreateVoter(global::System.String certnum, global::System.String lastName, global::System.String firstName)
        {
            Voter voter = new Voter();
            voter.Certnum = certnum;
            voter.LastName = lastName;
            voter.FirstName = firstName;
            return voter;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Certnum
        {
            get
            {
                return _Certnum;
            }
            set
            {
                if (_Certnum != value)
                {
                    OnCertnumChanging(value);
                    ReportPropertyChanging("Certnum");
                    _Certnum = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Certnum");
                    OnCertnumChanged();
                }
            }
        }
        private global::System.String _Certnum;
        partial void OnCertnumChanging(global::System.String value);
        partial void OnCertnumChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> Birthdate
        {
            get
            {
                return _Birthdate;
            }
            set
            {
                OnBirthdateChanging(value);
                ReportPropertyChanging("Birthdate");
                _Birthdate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Birthdate");
                OnBirthdateChanged();
            }
        }
        private Nullable<global::System.DateTime> _Birthdate;
        partial void OnBirthdateChanging(Nullable<global::System.DateTime> value);
        partial void OnBirthdateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String SSN
        {
            get
            {
                return _SSN;
            }
            set
            {
                OnSSNChanging(value);
                ReportPropertyChanging("SSN");
                _SSN = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("SSN");
                OnSSNChanged();
            }
        }
        private global::System.String _SSN;
        partial void OnSSNChanging(global::System.String value);
        partial void OnSSNChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Drivers_License
        {
            get
            {
                return _Drivers_License;
            }
            set
            {
                OnDrivers_LicenseChanging(value);
                ReportPropertyChanging("Drivers_License");
                _Drivers_License = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Drivers_License");
                OnDrivers_LicenseChanged();
            }
        }
        private global::System.String _Drivers_License;
        partial void OnDrivers_LicenseChanging(global::System.String value);
        partial void OnDrivers_LicenseChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Status
        {
            get
            {
                return _Status;
            }
            set
            {
                OnStatusChanging(value);
                ReportPropertyChanging("Status");
                _Status = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Status");
                OnStatusChanged();
            }
        }
        private global::System.String _Status;
        partial void OnStatusChanging(global::System.String value);
        partial void OnStatusChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Precinct
        {
            get
            {
                return _Precinct;
            }
            set
            {
                OnPrecinctChanging(value);
                ReportPropertyChanging("Precinct");
                _Precinct = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Precinct");
                OnPrecinctChanged();
            }
        }
        private Nullable<global::System.Int32> _Precinct;
        partial void OnPrecinctChanging(Nullable<global::System.Int32> value);
        partial void OnPrecinctChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Grp
        {
            get
            {
                return _Grp;
            }
            set
            {
                OnGrpChanging(value);
                ReportPropertyChanging("Grp");
                _Grp = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Grp");
                OnGrpChanged();
            }
        }
        private global::System.String _Grp;
        partial void OnGrpChanging(global::System.String value);
        partial void OnGrpChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> RegDate
        {
            get
            {
                return _RegDate;
            }
            set
            {
                OnRegDateChanging(value);
                ReportPropertyChanging("RegDate");
                _RegDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("RegDate");
                OnRegDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _RegDate;
        partial void OnRegDateChanging(Nullable<global::System.DateTime> value);
        partial void OnRegDateChanged();

        #endregion
    
    }

    #endregion
    
}
