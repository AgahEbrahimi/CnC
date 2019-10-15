﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Streaming_Client
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CnC")]
	public partial class CnC_DatabaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertStreaming_IP(Streaming_IP instance);
    partial void UpdateStreaming_IP(Streaming_IP instance);
    partial void DeleteStreaming_IP(Streaming_IP instance);
    partial void InsertStreaming_Command(Streaming_Command instance);
    partial void UpdateStreaming_Command(Streaming_Command instance);
    partial void DeleteStreaming_Command(Streaming_Command instance);
    #endregion
		
		public CnC_DatabaseDataContext() : 
				base(global::Streaming_Client.Properties.Settings.Default.CnCConnectionString2, mappingSource)
		{
			OnCreated();
		}
		
		public CnC_DatabaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CnC_DatabaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CnC_DatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CnC_DatabaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Streaming_IP> Streaming_IPs
		{
			get
			{
				return this.GetTable<Streaming_IP>();
			}
		}
		
		public System.Data.Linq.Table<Streaming_Command> Streaming_Commands
		{
			get
			{
				return this.GetTable<Streaming_Command>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Streaming_IPs")]
	public partial class Streaming_IP : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _User;
		
		private System.Nullable<int> _Port;
		
		private string _UserType;
		
		private string _IP;
		
		private int _ID;
		
		private string _AreOn;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserChanging(string value);
    partial void OnUserChanged();
    partial void OnPortChanging(System.Nullable<int> value);
    partial void OnPortChanged();
    partial void OnUserTypeChanging(string value);
    partial void OnUserTypeChanged();
    partial void OnIPChanging(string value);
    partial void OnIPChanged();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnAreOnChanging(string value);
    partial void OnAreOnChanged();
    #endregion
		
		public Streaming_IP()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[User]", Storage="_User", DbType="NVarChar(50)")]
		public string User
		{
			get
			{
				return this._User;
			}
			set
			{
				if ((this._User != value))
				{
					this.OnUserChanging(value);
					this.SendPropertyChanging();
					this._User = value;
					this.SendPropertyChanged("User");
					this.OnUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Port", DbType="Int")]
		public System.Nullable<int> Port
		{
			get
			{
				return this._Port;
			}
			set
			{
				if ((this._Port != value))
				{
					this.OnPortChanging(value);
					this.SendPropertyChanging();
					this._Port = value;
					this.SendPropertyChanged("Port");
					this.OnPortChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserType", DbType="NVarChar(50)")]
		public string UserType
		{
			get
			{
				return this._UserType;
			}
			set
			{
				if ((this._UserType != value))
				{
					this.OnUserTypeChanging(value);
					this.SendPropertyChanging();
					this._UserType = value;
					this.SendPropertyChanged("UserType");
					this.OnUserTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IP", DbType="NVarChar(50)")]
		public string IP
		{
			get
			{
				return this._IP;
			}
			set
			{
				if ((this._IP != value))
				{
					this.OnIPChanging(value);
					this.SendPropertyChanging();
					this._IP = value;
					this.SendPropertyChanged("IP");
					this.OnIPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AreOn", DbType="NVarChar(50)")]
		public string AreOn
		{
			get
			{
				return this._AreOn;
			}
			set
			{
				if ((this._AreOn != value))
				{
					this.OnAreOnChanging(value);
					this.SendPropertyChanging();
					this._AreOn = value;
					this.SendPropertyChanged("AreOn");
					this.OnAreOnChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Streaming_Command")]
	public partial class Streaming_Command : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _User;
		
		private string _Date;
		
		private System.Nullable<int> _Port;
		
		private int _ID;
		
		private string _Done;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserChanging(string value);
    partial void OnUserChanged();
    partial void OnDateChanging(string value);
    partial void OnDateChanged();
    partial void OnPortChanging(System.Nullable<int> value);
    partial void OnPortChanged();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnDoneChanging(string value);
    partial void OnDoneChanged();
    #endregion
		
		public Streaming_Command()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[User]", Storage="_User", DbType="NVarChar(50)")]
		public string User
		{
			get
			{
				return this._User;
			}
			set
			{
				if ((this._User != value))
				{
					this.OnUserChanging(value);
					this.SendPropertyChanging();
					this._User = value;
					this.SendPropertyChanged("User");
					this.OnUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="NVarChar(50)")]
		public string Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Port", DbType="Int")]
		public System.Nullable<int> Port
		{
			get
			{
				return this._Port;
			}
			set
			{
				if ((this._Port != value))
				{
					this.OnPortChanging(value);
					this.SendPropertyChanging();
					this._Port = value;
					this.SendPropertyChanged("Port");
					this.OnPortChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Done", DbType="NVarChar(50)")]
		public string Done
		{
			get
			{
				return this._Done;
			}
			set
			{
				if ((this._Done != value))
				{
					this.OnDoneChanging(value);
					this.SendPropertyChanging();
					this._Done = value;
					this.SendPropertyChanged("Done");
					this.OnDoneChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
