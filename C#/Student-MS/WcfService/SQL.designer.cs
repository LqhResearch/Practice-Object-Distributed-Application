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

namespace WcfService
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SINHVIENDB")]
	public partial class SQLDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertLop(Lop instance);
    partial void UpdateLop(Lop instance);
    partial void DeleteLop(Lop instance);
    partial void InsertSinhVien(SinhVien instance);
    partial void UpdateSinhVien(SinhVien instance);
    partial void DeleteSinhVien(SinhVien instance);
    #endregion
		
		public SQLDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SINHVIENDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SQLDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SQLDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SQLDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SQLDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Lop> Lops
		{
			get
			{
				return this.GetTable<Lop>();
			}
		}
		
		public System.Data.Linq.Table<SinhVien> SinhViens
		{
			get
			{
				return this.GetTable<SinhVien>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Lop")]
	public partial class Lop : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaLop;
		
		private string _TenLop;
		
		private EntitySet<SinhVien> _SinhViens;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaLopChanging(string value);
    partial void OnMaLopChanged();
    partial void OnTenLopChanging(string value);
    partial void OnTenLopChanged();
    #endregion
		
		public Lop()
		{
			this._SinhViens = new EntitySet<SinhVien>(new Action<SinhVien>(this.attach_SinhViens), new Action<SinhVien>(this.detach_SinhViens));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLop", DbType="NVarChar(16) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaLop
		{
			get
			{
				return this._MaLop;
			}
			set
			{
				if ((this._MaLop != value))
				{
					this.OnMaLopChanging(value);
					this.SendPropertyChanging();
					this._MaLop = value;
					this.SendPropertyChanged("MaLop");
					this.OnMaLopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenLop", DbType="NVarChar(64)")]
		public string TenLop
		{
			get
			{
				return this._TenLop;
			}
			set
			{
				if ((this._TenLop != value))
				{
					this.OnTenLopChanging(value);
					this.SendPropertyChanging();
					this._TenLop = value;
					this.SendPropertyChanged("TenLop");
					this.OnTenLopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Lop_SinhVien", Storage="_SinhViens", ThisKey="MaLop", OtherKey="MaLop")]
		internal EntitySet<SinhVien> SinhViens
		{
			get
			{
				return this._SinhViens;
			}
			set
			{
				this._SinhViens.Assign(value);
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
		
		private void attach_SinhViens(SinhVien entity)
		{
			this.SendPropertyChanging();
			entity.Lop = this;
		}
		
		private void detach_SinhViens(SinhVien entity)
		{
			this.SendPropertyChanging();
			entity.Lop = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SinhVien")]
	public partial class SinhVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MSSV;
		
		private string _HoTen;
		
		private string _QueQuan;
		
		private System.Nullable<int> _NamSinh;
		
		private string _GioiTinh;
		
		private string _MaLop;
		
		private EntityRef<Lop> _Lop;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMSSVChanging(string value);
    partial void OnMSSVChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnQueQuanChanging(string value);
    partial void OnQueQuanChanged();
    partial void OnNamSinhChanging(System.Nullable<int> value);
    partial void OnNamSinhChanged();
    partial void OnGioiTinhChanging(string value);
    partial void OnGioiTinhChanged();
    partial void OnMaLopChanging(string value);
    partial void OnMaLopChanged();
    #endregion
		
		public SinhVien()
		{
			this._Lop = default(EntityRef<Lop>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MSSV", DbType="VarChar(9) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MSSV
		{
			get
			{
				return this._MSSV;
			}
			set
			{
				if ((this._MSSV != value))
				{
					this.OnMSSVChanging(value);
					this.SendPropertyChanging();
					this._MSSV = value;
					this.SendPropertyChanged("MSSV");
					this.OnMSSVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(64)")]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QueQuan", DbType="NVarChar(255)")]
		public string QueQuan
		{
			get
			{
				return this._QueQuan;
			}
			set
			{
				if ((this._QueQuan != value))
				{
					this.OnQueQuanChanging(value);
					this.SendPropertyChanging();
					this._QueQuan = value;
					this.SendPropertyChanged("QueQuan");
					this.OnQueQuanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NamSinh", DbType="Int")]
		public System.Nullable<int> NamSinh
		{
			get
			{
				return this._NamSinh;
			}
			set
			{
				if ((this._NamSinh != value))
				{
					this.OnNamSinhChanging(value);
					this.SendPropertyChanging();
					this._NamSinh = value;
					this.SendPropertyChanged("NamSinh");
					this.OnNamSinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="NVarChar(5)")]
		public string GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLop", DbType="NVarChar(16) NOT NULL", CanBeNull=false)]
		public string MaLop
		{
			get
			{
				return this._MaLop;
			}
			set
			{
				if ((this._MaLop != value))
				{
					if (this._Lop.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaLopChanging(value);
					this.SendPropertyChanging();
					this._MaLop = value;
					this.SendPropertyChanged("MaLop");
					this.OnMaLopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Lop_SinhVien", Storage="_Lop", ThisKey="MaLop", OtherKey="MaLop", IsForeignKey=true)]
		public Lop Lop
		{
			get
			{
				return this._Lop.Entity;
			}
			set
			{
				Lop previousValue = this._Lop.Entity;
				if (((previousValue != value) 
							|| (this._Lop.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Lop.Entity = null;
						previousValue.SinhViens.Remove(this);
					}
					this._Lop.Entity = value;
					if ((value != null))
					{
						value.SinhViens.Add(this);
						this._MaLop = value.MaLop;
					}
					else
					{
						this._MaLop = default(string);
					}
					this.SendPropertyChanged("Lop");
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
