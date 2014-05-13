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
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("BankEntityModel", "CustomerAccount", "Customer", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Bank.Business.Entities.Customer), "Account", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Bank.Business.Entities.Account))]

#endregion

namespace Bank.Business.Entities
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class BankEntityModelContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new BankEntityModelContainer object using the connection string found in the 'BankEntityModelContainer' section of the application configuration file.
        /// </summary>
        public BankEntityModelContainer() : base("name=BankEntityModelContainer", "BankEntityModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new BankEntityModelContainer object.
        /// </summary>
        public BankEntityModelContainer(string connectionString) : base(connectionString, "BankEntityModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new BankEntityModelContainer object.
        /// </summary>
        public BankEntityModelContainer(EntityConnection connection) : base(connection, "BankEntityModelContainer")
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
        public ObjectSet<Customer> Customers
        {
            get
            {
                if ((_Customers == null))
                {
                    _Customers = base.CreateObjectSet<Customer>("Customers");
                }
                return _Customers;
            }
        }
        private ObjectSet<Customer> _Customers;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Account> Accounts
        {
            get
            {
                if ((_Accounts == null))
                {
                    _Accounts = base.CreateObjectSet<Account>("Accounts");
                }
                return _Accounts;
            }
        }
        private ObjectSet<Account> _Accounts;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Customers EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCustomers(Customer customer)
        {
            base.AddObject("Customers", customer);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Accounts EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAccounts(Account account)
        {
            base.AddObject("Accounts", account);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="BankEntityModel", Name="Account")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Account : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Account object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="accountNumber">Initial value of the AccountNumber property.</param>
        /// <param name="balance">Initial value of the Balance property.</param>
        public static Account CreateAccount(global::System.Int32 id, global::System.Int32 accountNumber, global::System.Decimal balance)
        {
            Account account = new Account();
            account.Id = id;
            account.AccountNumber = accountNumber;
            account.Balance = balance;
            return account;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 AccountNumber
        {
            get
            {
                return _AccountNumber;
            }
            set
            {
                OnAccountNumberChanging(value);
                ReportPropertyChanging("AccountNumber");
                _AccountNumber = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("AccountNumber");
                OnAccountNumberChanged();
            }
        }
        private global::System.Int32 _AccountNumber;
        partial void OnAccountNumberChanging(global::System.Int32 value);
        partial void OnAccountNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Balance
        {
            get
            {
                return _Balance;
            }
            set
            {
                OnBalanceChanging(value);
                ReportPropertyChanging("Balance");
                _Balance = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Balance");
                OnBalanceChanged();
            }
        }
        private global::System.Decimal _Balance;
        partial void OnBalanceChanging(global::System.Decimal value);
        partial void OnBalanceChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BankEntityModel", "CustomerAccount", "Customer")]
        public Customer Customer
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("BankEntityModel.CustomerAccount", "Customer").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("BankEntityModel.CustomerAccount", "Customer").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Customer> CustomerReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("BankEntityModel.CustomerAccount", "Customer");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Customer>("BankEntityModel.CustomerAccount", "Customer", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="BankEntityModel", Name="Customer")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Customer : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Customer object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static Customer CreateCustomer(global::System.Int32 id)
        {
            Customer customer = new Customer();
            customer.Id = id;
            return customer;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BankEntityModel", "CustomerAccount", "Account")]
        public EntityCollection<Account> Accounts
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Account>("BankEntityModel.CustomerAccount", "Account");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Account>("BankEntityModel.CustomerAccount", "Account", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
