//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace VideoStore.Business.Entities
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(Media))]
    public partial class Stock: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public System.Guid Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'Id' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _id = value;
                    OnPropertyChanged("Id");
                }
            }
        }
        private System.Guid _id;
    
        [DataMember]
        public string Warehouse
        {
            get { return _warehouse; }
            set
            {
                if (_warehouse != value)
                {
                    _warehouse = value;
                    OnPropertyChanged("Warehouse");
                }
            }
        }
        private string _warehouse;
    
        [DataMember]
        public Nullable<int> Holding
        {
            get { return _holding; }
            set
            {
                if (_holding != value)
                {
                    _holding = value;
                    OnPropertyChanged("Holding");
                }
            }
        }
        private Nullable<int> _holding;
    
        [DataMember]
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (_quantity != value)
                {
                    _quantity = value;
                    OnPropertyChanged("Quantity");
                }
            }
        }
        private int _quantity;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public Media Media
        {
            get { return _media; }
            set
            {
                if (!ReferenceEquals(_media, value))
                {
                    var previousValue = _media;
                    _media = value;
                    FixupMedia(previousValue);
                    OnNavigationPropertyChanged("Media");
                }
            }
        }
        private Media _media;

        #endregion
        #region ChangeTracking
    
        protected virtual void OnPropertyChanged(String propertyName)
        {
            if (ChangeTracker.State != ObjectState.Added && ChangeTracker.State != ObjectState.Deleted)
            {
                ChangeTracker.State = ObjectState.Modified;
            }
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        protected virtual void OnNavigationPropertyChanged(String propertyName)
        {
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged{ add { _propertyChanged += value; } remove { _propertyChanged -= value; } }
        private event PropertyChangedEventHandler _propertyChanged;
        private ObjectChangeTracker _changeTracker;
    
        [DataMember]
        public ObjectChangeTracker ChangeTracker
        {
            get
            {
                if (_changeTracker == null)
                {
                    _changeTracker = new ObjectChangeTracker();
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
                return _changeTracker;
            }
            set
            {
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging -= HandleObjectStateChanging;
                }
                _changeTracker = value;
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
            }
        }
    
        private void HandleObjectStateChanging(object sender, ObjectStateChangingEventArgs e)
        {
            if (e.NewState == ObjectState.Deleted)
            {
                ClearNavigationProperties();
            }
        }
    
        protected bool IsDeserializing { get; private set; }
    
        [OnDeserializing]
        public void OnDeserializingMethod(StreamingContext context)
        {
            IsDeserializing = true;
        }
    
        [OnDeserialized]
        public void OnDeserializedMethod(StreamingContext context)
        {
            IsDeserializing = false;
            ChangeTracker.ChangeTrackingEnabled = true;
        }
    
        protected virtual void ClearNavigationProperties()
        {
            Media = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupMedia(Media previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && ReferenceEquals(previousValue.Stocks, this))
            {
                previousValue.Stocks = null;
            }
    
            if (Media != null)
            {
                Media.Stocks = this;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Media")
                    && (ChangeTracker.OriginalValues["Media"] == Media))
                {
                    ChangeTracker.OriginalValues.Remove("Media");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("Media", previousValue);
                }
                if (Media != null && !Media.ChangeTracker.ChangeTrackingEnabled)
                {
                    Media.StartTracking();
                }
            }
        }

        #endregion
    }
}
