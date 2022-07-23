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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QUANLY_DEAN")]
	public partial class SQLDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDEAN(DEAN instance);
    partial void UpdateDEAN(DEAN instance);
    partial void DeleteDEAN(DEAN instance);
    partial void InsertPHONGBAN(PHONGBAN instance);
    partial void UpdatePHONGBAN(PHONGBAN instance);
    partial void DeletePHONGBAN(PHONGBAN instance);
    partial void InsertDIADIEMPHONG(DIADIEMPHONG instance);
    partial void UpdateDIADIEMPHONG(DIADIEMPHONG instance);
    partial void DeleteDIADIEMPHONG(DIADIEMPHONG instance);
    partial void InsertNHANVIEN(NHANVIEN instance);
    partial void UpdateNHANVIEN(NHANVIEN instance);
    partial void DeleteNHANVIEN(NHANVIEN instance);
    partial void InsertPHANCONG(PHANCONG instance);
    partial void UpdatePHANCONG(PHANCONG instance);
    partial void DeletePHANCONG(PHANCONG instance);
    #endregion
		
		public SQLDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QUANLY_DEANConnectionString1"].ConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<DEAN> DEANs
		{
			get
			{
				return this.GetTable<DEAN>();
			}
		}
		
		public System.Data.Linq.Table<PHONGBAN> PHONGBANs
		{
			get
			{
				return this.GetTable<PHONGBAN>();
			}
		}
		
		public System.Data.Linq.Table<DIADIEMPHONG> DIADIEMPHONGs
		{
			get
			{
				return this.GetTable<DIADIEMPHONG>();
			}
		}
		
		public System.Data.Linq.Table<NHANVIEN> NHANVIENs
		{
			get
			{
				return this.GetTable<NHANVIEN>();
			}
		}
		
		public System.Data.Linq.Table<PHANCONG> PHANCONGs
		{
			get
			{
				return this.GetTable<PHANCONG>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DEAN")]
	public partial class DEAN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MADA;
		
		private string _TENDA;
		
		private string _DIADIEMDA;
		
		private System.Nullable<int> _MAPHONG;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMADAChanging(int value);
    partial void OnMADAChanged();
    partial void OnTENDAChanging(string value);
    partial void OnTENDAChanged();
    partial void OnDIADIEMDAChanging(string value);
    partial void OnDIADIEMDAChanged();
    partial void OnMAPHONGChanging(System.Nullable<int> value);
    partial void OnMAPHONGChanged();
    #endregion
		
		public DEAN()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MADA", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MADA
		{
			get
			{
				return this._MADA;
			}
			set
			{
				if ((this._MADA != value))
				{
					this.OnMADAChanging(value);
					this.SendPropertyChanging();
					this._MADA = value;
					this.SendPropertyChanged("MADA");
					this.OnMADAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENDA", DbType="NVarChar(50)")]
		public string TENDA
		{
			get
			{
				return this._TENDA;
			}
			set
			{
				if ((this._TENDA != value))
				{
					this.OnTENDAChanging(value);
					this.SendPropertyChanging();
					this._TENDA = value;
					this.SendPropertyChanged("TENDA");
					this.OnTENDAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIADIEMDA", DbType="NVarChar(50)")]
		public string DIADIEMDA
		{
			get
			{
				return this._DIADIEMDA;
			}
			set
			{
				if ((this._DIADIEMDA != value))
				{
					this.OnDIADIEMDAChanging(value);
					this.SendPropertyChanging();
					this._DIADIEMDA = value;
					this.SendPropertyChanged("DIADIEMDA");
					this.OnDIADIEMDAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAPHONG", DbType="Int")]
		public System.Nullable<int> MAPHONG
		{
			get
			{
				return this._MAPHONG;
			}
			set
			{
				if ((this._MAPHONG != value))
				{
					this.OnMAPHONGChanging(value);
					this.SendPropertyChanging();
					this._MAPHONG = value;
					this.SendPropertyChanged("MAPHONG");
					this.OnMAPHONGChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PHONGBAN")]
	public partial class PHONGBAN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MAPHONG;
		
		private string _TENPHONG;
		
		private string _TRUONGPHONG;
		
		private System.Nullable<System.DateTime> _NGAYNHANCHUC;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAPHONGChanging(int value);
    partial void OnMAPHONGChanged();
    partial void OnTENPHONGChanging(string value);
    partial void OnTENPHONGChanged();
    partial void OnTRUONGPHONGChanging(string value);
    partial void OnTRUONGPHONGChanged();
    partial void OnNGAYNHANCHUCChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYNHANCHUCChanged();
    #endregion
		
		public PHONGBAN()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAPHONG", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MAPHONG
		{
			get
			{
				return this._MAPHONG;
			}
			set
			{
				if ((this._MAPHONG != value))
				{
					this.OnMAPHONGChanging(value);
					this.SendPropertyChanging();
					this._MAPHONG = value;
					this.SendPropertyChanged("MAPHONG");
					this.OnMAPHONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENPHONG", DbType="NVarChar(30)")]
		public string TENPHONG
		{
			get
			{
				return this._TENPHONG;
			}
			set
			{
				if ((this._TENPHONG != value))
				{
					this.OnTENPHONGChanging(value);
					this.SendPropertyChanging();
					this._TENPHONG = value;
					this.SendPropertyChanged("TENPHONG");
					this.OnTENPHONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TRUONGPHONG", DbType="Char(9)")]
		public string TRUONGPHONG
		{
			get
			{
				return this._TRUONGPHONG;
			}
			set
			{
				if ((this._TRUONGPHONG != value))
				{
					this.OnTRUONGPHONGChanging(value);
					this.SendPropertyChanging();
					this._TRUONGPHONG = value;
					this.SendPropertyChanged("TRUONGPHONG");
					this.OnTRUONGPHONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYNHANCHUC", DbType="DateTime")]
		public System.Nullable<System.DateTime> NGAYNHANCHUC
		{
			get
			{
				return this._NGAYNHANCHUC;
			}
			set
			{
				if ((this._NGAYNHANCHUC != value))
				{
					this.OnNGAYNHANCHUCChanging(value);
					this.SendPropertyChanging();
					this._NGAYNHANCHUC = value;
					this.SendPropertyChanged("NGAYNHANCHUC");
					this.OnNGAYNHANCHUCChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DIADIEMPHONG")]
	public partial class DIADIEMPHONG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MAPHONG;
		
		private string _DIADIEM;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAPHONGChanging(int value);
    partial void OnMAPHONGChanged();
    partial void OnDIADIEMChanging(string value);
    partial void OnDIADIEMChanged();
    #endregion
		
		public DIADIEMPHONG()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAPHONG", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MAPHONG
		{
			get
			{
				return this._MAPHONG;
			}
			set
			{
				if ((this._MAPHONG != value))
				{
					this.OnMAPHONGChanging(value);
					this.SendPropertyChanging();
					this._MAPHONG = value;
					this.SendPropertyChanged("MAPHONG");
					this.OnMAPHONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIADIEM", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string DIADIEM
		{
			get
			{
				return this._DIADIEM;
			}
			set
			{
				if ((this._DIADIEM != value))
				{
					this.OnDIADIEMChanging(value);
					this.SendPropertyChanging();
					this._DIADIEM = value;
					this.SendPropertyChanged("DIADIEM");
					this.OnDIADIEMChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NHANVIEN")]
	public partial class NHANVIEN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MANV;
		
		private string _HONV;
		
		private string _TENLOTNV;
		
		private string _TENNV;
		
		private System.Nullable<System.DateTime> _NGAYSINH;
		
		private string _PHAI;
		
		private string _DIACHI;
		
		private System.Nullable<decimal> _HSLUONG;
		
		private string _MANQL;
		
		private System.Nullable<int> _MAPHONG;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMANVChanging(string value);
    partial void OnMANVChanged();
    partial void OnHONVChanging(string value);
    partial void OnHONVChanged();
    partial void OnTENLOTNVChanging(string value);
    partial void OnTENLOTNVChanged();
    partial void OnTENNVChanging(string value);
    partial void OnTENNVChanged();
    partial void OnNGAYSINHChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYSINHChanged();
    partial void OnPHAIChanging(string value);
    partial void OnPHAIChanged();
    partial void OnDIACHIChanging(string value);
    partial void OnDIACHIChanged();
    partial void OnHSLUONGChanging(System.Nullable<decimal> value);
    partial void OnHSLUONGChanged();
    partial void OnMANQLChanging(string value);
    partial void OnMANQLChanged();
    partial void OnMAPHONGChanging(System.Nullable<int> value);
    partial void OnMAPHONGChanged();
    #endregion
		
		public NHANVIEN()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MANV", DbType="Char(9) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MANV
		{
			get
			{
				return this._MANV;
			}
			set
			{
				if ((this._MANV != value))
				{
					this.OnMANVChanging(value);
					this.SendPropertyChanging();
					this._MANV = value;
					this.SendPropertyChanged("MANV");
					this.OnMANVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HONV", DbType="NVarChar(10)")]
		public string HONV
		{
			get
			{
				return this._HONV;
			}
			set
			{
				if ((this._HONV != value))
				{
					this.OnHONVChanging(value);
					this.SendPropertyChanging();
					this._HONV = value;
					this.SendPropertyChanged("HONV");
					this.OnHONVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENLOTNV", DbType="NVarChar(20)")]
		public string TENLOTNV
		{
			get
			{
				return this._TENLOTNV;
			}
			set
			{
				if ((this._TENLOTNV != value))
				{
					this.OnTENLOTNVChanging(value);
					this.SendPropertyChanging();
					this._TENLOTNV = value;
					this.SendPropertyChanged("TENLOTNV");
					this.OnTENLOTNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENNV", DbType="NVarChar(10)")]
		public string TENNV
		{
			get
			{
				return this._TENNV;
			}
			set
			{
				if ((this._TENNV != value))
				{
					this.OnTENNVChanging(value);
					this.SendPropertyChanging();
					this._TENNV = value;
					this.SendPropertyChanged("TENNV");
					this.OnTENNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYSINH", DbType="DateTime")]
		public System.Nullable<System.DateTime> NGAYSINH
		{
			get
			{
				return this._NGAYSINH;
			}
			set
			{
				if ((this._NGAYSINH != value))
				{
					this.OnNGAYSINHChanging(value);
					this.SendPropertyChanging();
					this._NGAYSINH = value;
					this.SendPropertyChanged("NGAYSINH");
					this.OnNGAYSINHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PHAI", DbType="Char(3)")]
		public string PHAI
		{
			get
			{
				return this._PHAI;
			}
			set
			{
				if ((this._PHAI != value))
				{
					this.OnPHAIChanging(value);
					this.SendPropertyChanging();
					this._PHAI = value;
					this.SendPropertyChanged("PHAI");
					this.OnPHAIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIACHI", DbType="NVarChar(50)")]
		public string DIACHI
		{
			get
			{
				return this._DIACHI;
			}
			set
			{
				if ((this._DIACHI != value))
				{
					this.OnDIACHIChanging(value);
					this.SendPropertyChanging();
					this._DIACHI = value;
					this.SendPropertyChanged("DIACHI");
					this.OnDIACHIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HSLUONG", DbType="Decimal(3,2)")]
		public System.Nullable<decimal> HSLUONG
		{
			get
			{
				return this._HSLUONG;
			}
			set
			{
				if ((this._HSLUONG != value))
				{
					this.OnHSLUONGChanging(value);
					this.SendPropertyChanging();
					this._HSLUONG = value;
					this.SendPropertyChanged("HSLUONG");
					this.OnHSLUONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MANQL", DbType="Char(9)")]
		public string MANQL
		{
			get
			{
				return this._MANQL;
			}
			set
			{
				if ((this._MANQL != value))
				{
					this.OnMANQLChanging(value);
					this.SendPropertyChanging();
					this._MANQL = value;
					this.SendPropertyChanged("MANQL");
					this.OnMANQLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAPHONG", DbType="Int")]
		public System.Nullable<int> MAPHONG
		{
			get
			{
				return this._MAPHONG;
			}
			set
			{
				if ((this._MAPHONG != value))
				{
					this.OnMAPHONGChanging(value);
					this.SendPropertyChanging();
					this._MAPHONG = value;
					this.SendPropertyChanged("MAPHONG");
					this.OnMAPHONGChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PHANCONG")]
	public partial class PHANCONG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MANV;
		
		private int _MADA;
		
		private System.Nullable<decimal> _THOIGIAN;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMANVChanging(string value);
    partial void OnMANVChanged();
    partial void OnMADAChanging(int value);
    partial void OnMADAChanged();
    partial void OnTHOIGIANChanging(System.Nullable<decimal> value);
    partial void OnTHOIGIANChanged();
    #endregion
		
		public PHANCONG()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MANV", DbType="Char(9) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MANV
		{
			get
			{
				return this._MANV;
			}
			set
			{
				if ((this._MANV != value))
				{
					this.OnMANVChanging(value);
					this.SendPropertyChanging();
					this._MANV = value;
					this.SendPropertyChanged("MANV");
					this.OnMANVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MADA", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MADA
		{
			get
			{
				return this._MADA;
			}
			set
			{
				if ((this._MADA != value))
				{
					this.OnMADAChanging(value);
					this.SendPropertyChanging();
					this._MADA = value;
					this.SendPropertyChanged("MADA");
					this.OnMADAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_THOIGIAN", DbType="Decimal(3,1)")]
		public System.Nullable<decimal> THOIGIAN
		{
			get
			{
				return this._THOIGIAN;
			}
			set
			{
				if ((this._THOIGIAN != value))
				{
					this.OnTHOIGIANChanging(value);
					this.SendPropertyChanging();
					this._THOIGIAN = value;
					this.SendPropertyChanged("THOIGIAN");
					this.OnTHOIGIANChanged();
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
