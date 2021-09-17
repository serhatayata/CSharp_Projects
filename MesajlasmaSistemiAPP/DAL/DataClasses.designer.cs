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

namespace DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MesajlasmaDB")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTBL_KISILER(TBL_KISILER instance);
    partial void UpdateTBL_KISILER(TBL_KISILER instance);
    partial void DeleteTBL_KISILER(TBL_KISILER instance);
    partial void InsertTBL_MESAJLAR(TBL_MESAJLAR instance);
    partial void UpdateTBL_MESAJLAR(TBL_MESAJLAR instance);
    partial void DeleteTBL_MESAJLAR(TBL_MESAJLAR instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::DAL.Properties.Settings.Default.MesajlasmaDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TBL_KISILER> TBL_KISILERs
		{
			get
			{
				return this.GetTable<TBL_KISILER>();
			}
		}
		
		public System.Data.Linq.Table<TBL_MESAJLAR> TBL_MESAJLARs
		{
			get
			{
				return this.GetTable<TBL_MESAJLAR>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TBL_KISILER")]
	public partial class TBL_KISILER : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _AD;
		
		private string _SOYAD;
		
		private string _NUMARA;
		
		private string _SIFRE;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnADChanging(string value);
    partial void OnADChanged();
    partial void OnSOYADChanging(string value);
    partial void OnSOYADChanged();
    partial void OnNUMARAChanging(string value);
    partial void OnNUMARAChanged();
    partial void OnSIFREChanging(string value);
    partial void OnSIFREChanged();
    #endregion
		
		public TBL_KISILER()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AD", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string AD
		{
			get
			{
				return this._AD;
			}
			set
			{
				if ((this._AD != value))
				{
					this.OnADChanging(value);
					this.SendPropertyChanging();
					this._AD = value;
					this.SendPropertyChanged("AD");
					this.OnADChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SOYAD", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SOYAD
		{
			get
			{
				return this._SOYAD;
			}
			set
			{
				if ((this._SOYAD != value))
				{
					this.OnSOYADChanging(value);
					this.SendPropertyChanging();
					this._SOYAD = value;
					this.SendPropertyChanged("SOYAD");
					this.OnSOYADChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NUMARA", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string NUMARA
		{
			get
			{
				return this._NUMARA;
			}
			set
			{
				if ((this._NUMARA != value))
				{
					this.OnNUMARAChanging(value);
					this.SendPropertyChanging();
					this._NUMARA = value;
					this.SendPropertyChanged("NUMARA");
					this.OnNUMARAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SIFRE", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SIFRE
		{
			get
			{
				return this._SIFRE;
			}
			set
			{
				if ((this._SIFRE != value))
				{
					this.OnSIFREChanging(value);
					this.SendPropertyChanging();
					this._SIFRE = value;
					this.SendPropertyChanged("SIFRE");
					this.OnSIFREChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TBL_MESAJLAR")]
	public partial class TBL_MESAJLAR : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MESAJID;
		
		private string _GONDEREN;
		
		private string _ALICI;
		
		private string _BASLIK;
		
		private string _ICERIK;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMESAJIDChanging(int value);
    partial void OnMESAJIDChanged();
    partial void OnGONDERENChanging(string value);
    partial void OnGONDERENChanged();
    partial void OnALICIChanging(string value);
    partial void OnALICIChanged();
    partial void OnBASLIKChanging(string value);
    partial void OnBASLIKChanged();
    partial void OnICERIKChanging(string value);
    partial void OnICERIKChanged();
    #endregion
		
		public TBL_MESAJLAR()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MESAJID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MESAJID
		{
			get
			{
				return this._MESAJID;
			}
			set
			{
				if ((this._MESAJID != value))
				{
					this.OnMESAJIDChanging(value);
					this.SendPropertyChanging();
					this._MESAJID = value;
					this.SendPropertyChanged("MESAJID");
					this.OnMESAJIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GONDEREN", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string GONDEREN
		{
			get
			{
				return this._GONDEREN;
			}
			set
			{
				if ((this._GONDEREN != value))
				{
					this.OnGONDERENChanging(value);
					this.SendPropertyChanging();
					this._GONDEREN = value;
					this.SendPropertyChanged("GONDEREN");
					this.OnGONDERENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ALICI", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string ALICI
		{
			get
			{
				return this._ALICI;
			}
			set
			{
				if ((this._ALICI != value))
				{
					this.OnALICIChanging(value);
					this.SendPropertyChanging();
					this._ALICI = value;
					this.SendPropertyChanged("ALICI");
					this.OnALICIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BASLIK", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string BASLIK
		{
			get
			{
				return this._BASLIK;
			}
			set
			{
				if ((this._BASLIK != value))
				{
					this.OnBASLIKChanging(value);
					this.SendPropertyChanging();
					this._BASLIK = value;
					this.SendPropertyChanged("BASLIK");
					this.OnBASLIKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ICERIK", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string ICERIK
		{
			get
			{
				return this._ICERIK;
			}
			set
			{
				if ((this._ICERIK != value))
				{
					this.OnICERIKChanging(value);
					this.SendPropertyChanging();
					this._ICERIK = value;
					this.SendPropertyChanged("ICERIK");
					this.OnICERIKChanged();
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
