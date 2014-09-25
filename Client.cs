using System;

namespace DefaultScope
{
	public static class ContextFactory
	{
		public static Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineContext CreateContext(string cachePath, System.Uri serviceUri)
		{
			return new DefaultScope.OfflineContext(cachePath, serviceUri);
		}

		public static String ScopeName
		{
			get
			{
				return "DefaultScope";
			}
		}

		public static String ConfigName
		{
			get
			{
				return "UPOLand";
			}
		}

		public static String Version
		{
			get
			{
				return "1.2.0.35";
			}
		}
		
	}
}

namespace DefaultScope 
{
	 
	namespace admin 
	{
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Entity : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("admin_Entity", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private String _Name;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Name 
			{
				get 
				{
					return _Name;
				}
				set 
				{
					base.OnPropertyChanging("Name");					
					_Name = value;
					base.OnPropertyChanged("Name");
				}
			}
			
			
			private String _Schema;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Schema 
			{
				get 
				{
					return _Schema;
				}
				set 
				{
					base.OnPropertyChanging("Schema");					
					_Schema = value;
					base.OnPropertyChanged("Schema");
				}
			}
			
			
			private String _ShortName;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String ShortName 
			{
				get 
				{
					return _ShortName;
				}
				set 
				{
					base.OnPropertyChanging("ShortName");					
					_ShortName = value;
					base.OnPropertyChanged("ShortName");
				}
			}
			
			
			public static Entity CreateInstance(OfflineContext dao)
            {
                Entity entity = new Entity();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<Entity>(entity);
                return entity;
            }

					}

		        
		
		public class Collections
		{
			private OfflineContext context;

			public Collections(OfflineContext context)
			{
				this.context = context;
			}

			 

			public System.Collections.Generic.IEnumerable<admin.Entity> Entity 
			{
				get 
				{
					return context.GetCollection<admin.Entity>();
				}
			}


			
					}

	}

	 
	namespace Catalog 
	{
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Counterparty : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private System.Nullable<bool> _Predefined;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Predefined 
			{
				get 
				{
					return _Predefined;
				}
				set 
				{
					base.OnPropertyChanging("Predefined");					
					_Predefined = value;
					base.OnPropertyChanged("Predefined");
				}
			}
			
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Counterparty", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private System.Nullable<bool> _DeletionMark;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DeletionMark 
			{
				get 
				{
					return _DeletionMark;
				}
				set 
				{
					base.OnPropertyChanging("DeletionMark");					
					_DeletionMark = value;
					base.OnPropertyChanged("DeletionMark");
				}
			}
			
			
			private System.Nullable<bool> _IsFolder;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> IsFolder 
			{
				get 
				{
					return _IsFolder;
				}
				set 
				{
					base.OnPropertyChanging("IsFolder");					
					_IsFolder = value;
					base.OnPropertyChanged("IsFolder");
				}
			}
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			private String _Code;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Code 
			{
				get 
				{
					return _Code;
				}
				set 
				{
					base.OnPropertyChanging("Code");					
					_Code = value;
					base.OnPropertyChanged("Code");
				}
			}
			
			
			public static Counterparty CreateInstance(OfflineContext dao)
            {
                Counterparty entity = new Counterparty();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<Counterparty>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class ContactName : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private System.Nullable<bool> _Predefined;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Predefined 
			{
				get 
				{
					return _Predefined;
				}
				set 
				{
					base.OnPropertyChanging("Predefined");					
					_Predefined = value;
					base.OnPropertyChanged("Predefined");
				}
			}
			
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_ContactName", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private System.Nullable<bool> _DeletionMark;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DeletionMark 
			{
				get 
				{
					return _DeletionMark;
				}
				set 
				{
					base.OnPropertyChanging("DeletionMark");					
					_DeletionMark = value;
					base.OnPropertyChanged("DeletionMark");
				}
			}
			
			
			private Guid _Owner;				    

						public Guid __Owner 
			{
				get 
				{
					return _Owner;
				}
				set
				{
					_Owner = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Owner
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Counterparty", _Owner);
									}
				set
				{
					base.OnPropertyChanging("Owner");
					_Owner = value.Id;
					base.OnPropertyChanged("Owner");
				}
			}								
			
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			private String _Code;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Code 
			{
				get 
				{
					return _Code;
				}
				set 
				{
					base.OnPropertyChanging("Code");					
					_Code = value;
					base.OnPropertyChanged("Code");
				}
			}
			
			
			private String _ContactPosition;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String ContactPosition 
			{
				get 
				{
					return _ContactPosition;
				}
				set 
				{
					base.OnPropertyChanging("ContactPosition");					
					_ContactPosition = value;
					base.OnPropertyChanged("ContactPosition");
				}
			}
			
			
			public static ContactName CreateInstance(OfflineContext dao)
            {
                ContactName entity = new ContactName();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<ContactName>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class ContactPosition : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private System.Nullable<bool> _Predefined;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Predefined 
			{
				get 
				{
					return _Predefined;
				}
				set 
				{
					base.OnPropertyChanging("Predefined");					
					_Predefined = value;
					base.OnPropertyChanged("Predefined");
				}
			}
			
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_ContactPosition", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private System.Nullable<bool> _DeletionMark;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DeletionMark 
			{
				get 
				{
					return _DeletionMark;
				}
				set 
				{
					base.OnPropertyChanging("DeletionMark");					
					_DeletionMark = value;
					base.OnPropertyChanged("DeletionMark");
				}
			}
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			private String _Code;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Code 
			{
				get 
				{
					return _Code;
				}
				set 
				{
					base.OnPropertyChanging("Code");					
					_Code = value;
					base.OnPropertyChanged("Code");
				}
			}
			
			
			public static ContactPosition CreateInstance(OfflineContext dao)
            {
                ContactPosition entity = new ContactPosition();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<ContactPosition>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class TypesOfSettlement : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private System.Nullable<bool> _Predefined;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Predefined 
			{
				get 
				{
					return _Predefined;
				}
				set 
				{
					base.OnPropertyChanging("Predefined");					
					_Predefined = value;
					base.OnPropertyChanged("Predefined");
				}
			}
			
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_TypesOfSettlement", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private System.Nullable<bool> _DeletionMark;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DeletionMark 
			{
				get 
				{
					return _DeletionMark;
				}
				set 
				{
					base.OnPropertyChanging("DeletionMark");					
					_DeletionMark = value;
					base.OnPropertyChanged("DeletionMark");
				}
			}
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			private String _Code;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Code 
			{
				get 
				{
					return _Code;
				}
				set 
				{
					base.OnPropertyChanging("Code");					
					_Code = value;
					base.OnPropertyChanged("Code");
				}
			}
			
			
			public static TypesOfSettlement CreateInstance(OfflineContext dao)
            {
                TypesOfSettlement entity = new TypesOfSettlement();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<TypesOfSettlement>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class TypeOfWork : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private System.Nullable<bool> _Predefined;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Predefined 
			{
				get 
				{
					return _Predefined;
				}
				set 
				{
					base.OnPropertyChanging("Predefined");					
					_Predefined = value;
					base.OnPropertyChanged("Predefined");
				}
			}
			
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_TypeOfWork", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private System.Nullable<bool> _DeletionMark;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DeletionMark 
			{
				get 
				{
					return _DeletionMark;
				}
				set 
				{
					base.OnPropertyChanging("DeletionMark");					
					_DeletionMark = value;
					base.OnPropertyChanged("DeletionMark");
				}
			}
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			private String _Code;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Code 
			{
				get 
				{
					return _Code;
				}
				set 
				{
					base.OnPropertyChanging("Code");					
					_Code = value;
					base.OnPropertyChanged("Code");
				}
			}
			
			
			public static TypeOfWork CreateInstance(OfflineContext dao)
            {
                TypeOfWork entity = new TypeOfWork();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<TypeOfWork>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Org : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private System.Nullable<bool> _Predefined;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Predefined 
			{
				get 
				{
					return _Predefined;
				}
				set 
				{
					base.OnPropertyChanging("Predefined");					
					_Predefined = value;
					base.OnPropertyChanged("Predefined");
				}
			}
			
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Org", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private System.Nullable<bool> _DeletionMark;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DeletionMark 
			{
				get 
				{
					return _DeletionMark;
				}
				set 
				{
					base.OnPropertyChanging("DeletionMark");					
					_DeletionMark = value;
					base.OnPropertyChanged("DeletionMark");
				}
			}
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			private String _Code;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Code 
			{
				get 
				{
					return _Code;
				}
				set 
				{
					base.OnPropertyChanging("Code");					
					_Code = value;
					base.OnPropertyChanged("Code");
				}
			}
			
			
			public static Org CreateInstance(OfflineContext dao)
            {
                Org entity = new Org();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<Org>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Users : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private System.Nullable<bool> _Predefined;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Predefined 
			{
				get 
				{
					return _Predefined;
				}
				set 
				{
					base.OnPropertyChanging("Predefined");					
					_Predefined = value;
					base.OnPropertyChanged("Predefined");
				}
			}
			
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Users", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private System.Nullable<bool> _DeletionMark;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DeletionMark 
			{
				get 
				{
					return _DeletionMark;
				}
				set 
				{
					base.OnPropertyChanging("DeletionMark");					
					_DeletionMark = value;
					base.OnPropertyChanged("DeletionMark");
				}
			}
			
			
			private System.Nullable<bool> _IsFolder;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> IsFolder 
			{
				get 
				{
					return _IsFolder;
				}
				set 
				{
					base.OnPropertyChanging("IsFolder");					
					_IsFolder = value;
					base.OnPropertyChanged("IsFolder");
				}
			}
			
			
			private Guid _Parent;				    

						public Guid __Parent 
			{
				get 
				{
					return _Parent;
				}
				set
				{
					_Parent = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Parent
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Users", _Parent);
									}
				set
				{
					base.OnPropertyChanging("Parent");
					_Parent = value.Id;
					base.OnPropertyChanged("Parent");
				}
			}								
			
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			private String _Code;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Code 
			{
				get 
				{
					return _Code;
				}
				set 
				{
					base.OnPropertyChanging("Code");					
					_Code = value;
					base.OnPropertyChanged("Code");
				}
			}
			
			
			public static Users CreateInstance(OfflineContext dao)
            {
                Users entity = new Users();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<Users>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class ObjectContactName : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private System.Nullable<bool> _Predefined;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Predefined 
			{
				get 
				{
					return _Predefined;
				}
				set 
				{
					base.OnPropertyChanging("Predefined");					
					_Predefined = value;
					base.OnPropertyChanged("Predefined");
				}
			}
			
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_ObjectContactName", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private System.Nullable<bool> _DeletionMark;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DeletionMark 
			{
				get 
				{
					return _DeletionMark;
				}
				set 
				{
					base.OnPropertyChanging("DeletionMark");					
					_DeletionMark = value;
					base.OnPropertyChanged("DeletionMark");
				}
			}
			
			
			private System.Nullable<bool> _IsFolder;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> IsFolder 
			{
				get 
				{
					return _IsFolder;
				}
				set 
				{
					base.OnPropertyChanging("IsFolder");					
					_IsFolder = value;
					base.OnPropertyChanged("IsFolder");
				}
			}
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			private String _Code;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Code 
			{
				get 
				{
					return _Code;
				}
				set 
				{
					base.OnPropertyChanging("Code");					
					_Code = value;
					base.OnPropertyChanged("Code");
				}
			}
			
			
			public static ObjectContactName CreateInstance(OfflineContext dao)
            {
                ObjectContactName entity = new ObjectContactName();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<ObjectContactName>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class GroupObjects : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private System.Nullable<bool> _Predefined;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Predefined 
			{
				get 
				{
					return _Predefined;
				}
				set 
				{
					base.OnPropertyChanging("Predefined");					
					_Predefined = value;
					base.OnPropertyChanged("Predefined");
				}
			}
			
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_GroupObjects", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private System.Nullable<bool> _DeletionMark;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DeletionMark 
			{
				get 
				{
					return _DeletionMark;
				}
				set 
				{
					base.OnPropertyChanging("DeletionMark");					
					_DeletionMark = value;
					base.OnPropertyChanged("DeletionMark");
				}
			}
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			private String _Code;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Code 
			{
				get 
				{
					return _Code;
				}
				set 
				{
					base.OnPropertyChanging("Code");					
					_Code = value;
					base.OnPropertyChanged("Code");
				}
			}
			
			
			public static GroupObjects CreateInstance(OfflineContext dao)
            {
                GroupObjects entity = new GroupObjects();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<GroupObjects>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class DutyRegions : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private System.Nullable<bool> _Predefined;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Predefined 
			{
				get 
				{
					return _Predefined;
				}
				set 
				{
					base.OnPropertyChanging("Predefined");					
					_Predefined = value;
					base.OnPropertyChanged("Predefined");
				}
			}
			
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_DutyRegions", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private System.Nullable<bool> _DeletionMark;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DeletionMark 
			{
				get 
				{
					return _DeletionMark;
				}
				set 
				{
					base.OnPropertyChanging("DeletionMark");					
					_DeletionMark = value;
					base.OnPropertyChanged("DeletionMark");
				}
			}
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			private String _Code;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Code 
			{
				get 
				{
					return _Code;
				}
				set 
				{
					base.OnPropertyChanging("Code");					
					_Code = value;
					base.OnPropertyChanged("Code");
				}
			}
			
			
			public static DutyRegions CreateInstance(OfflineContext dao)
            {
                DutyRegions entity = new DutyRegions();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<DutyRegions>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Object : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private System.Nullable<bool> _Predefined;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Predefined 
			{
				get 
				{
					return _Predefined;
				}
				set 
				{
					base.OnPropertyChanging("Predefined");					
					_Predefined = value;
					base.OnPropertyChanged("Predefined");
				}
			}
			
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Object", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private System.Nullable<bool> _DeletionMark;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DeletionMark 
			{
				get 
				{
					return _DeletionMark;
				}
				set 
				{
					base.OnPropertyChanging("DeletionMark");					
					_DeletionMark = value;
					base.OnPropertyChanged("DeletionMark");
				}
			}
			
			
			private Guid _Owner;				    

						public Guid __Owner 
			{
				get 
				{
					return _Owner;
				}
				set
				{
					_Owner = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Owner
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Counterparty", _Owner);
									}
				set
				{
					base.OnPropertyChanging("Owner");
					_Owner = value.Id;
					base.OnPropertyChanged("Owner");
				}
			}								
			
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			private String _Code;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Code 
			{
				get 
				{
					return _Code;
				}
				set 
				{
					base.OnPropertyChanging("Code");					
					_Code = value;
					base.OnPropertyChanged("Code");
				}
			}
			
			
			private System.Nullable<decimal> _Longitude;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<decimal> Longitude 
			{
				get 
				{
					return _Longitude;
				}
				set 
				{
					base.OnPropertyChanging("Longitude");					
					_Longitude = value;
					base.OnPropertyChanged("Longitude");
				}
			}
			
			
			private System.Nullable<decimal> _Latitude;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<decimal> Latitude 
			{
				get 
				{
					return _Latitude;
				}
				set 
				{
					base.OnPropertyChanging("Latitude");					
					_Latitude = value;
					base.OnPropertyChanged("Latitude");
				}
			}
			
			
			private String _Address;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Address 
			{
				get 
				{
					return _Address;
				}
				set 
				{
					base.OnPropertyChanging("Address");					
					_Address = value;
					base.OnPropertyChanged("Address");
				}
			}
			
			
			private String _Region;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Region 
			{
				get 
				{
					return _Region;
				}
				set 
				{
					base.OnPropertyChanging("Region");					
					_Region = value;
					base.OnPropertyChanged("Region");
				}
			}
			
			
			private System.Nullable<DateTime> _DateOfInstallation;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<DateTime> DateOfInstallation 
			{
				get 
				{
					return _DateOfInstallation;
				}
				set 
				{
					base.OnPropertyChanging("DateOfInstallation");					
					_DateOfInstallation = value;
					base.OnPropertyChanged("DateOfInstallation");
				}
			}
			
			
			private Guid _ObjectContactName;				    

						public Guid __ObjectContactName 
			{
				get 
				{
					return _ObjectContactName;
				}
				set
				{
					_ObjectContactName = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef ObjectContactName
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_ObjectContactName", _ObjectContactName);
									}
				set
				{
					base.OnPropertyChanging("ObjectContactName");
					_ObjectContactName = value.Id;
					base.OnPropertyChanged("ObjectContactName");
				}
			}								
			
			
			
			private String _ContactTel;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String ContactTel 
			{
				get 
				{
					return _ContactTel;
				}
				set 
				{
					base.OnPropertyChanging("ContactTel");					
					_ContactTel = value;
					base.OnPropertyChanged("ContactTel");
				}
			}
			
			
			private Guid _ContactPosition;				    

						public Guid __ContactPosition 
			{
				get 
				{
					return _ContactPosition;
				}
				set
				{
					_ContactPosition = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef ContactPosition
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_ContactPosition", _ContactPosition);
									}
				set
				{
					base.OnPropertyChanging("ContactPosition");
					_ContactPosition = value.Id;
					base.OnPropertyChanged("ContactPosition");
				}
			}								
			
			
			
			private Guid _DutyRegions;				    

						public Guid __DutyRegions 
			{
				get 
				{
					return _DutyRegions;
				}
				set
				{
					_DutyRegions = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef DutyRegions
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_DutyRegions", _DutyRegions);
									}
				set
				{
					base.OnPropertyChanging("DutyRegions");
					_DutyRegions = value.Id;
					base.OnPropertyChanged("DutyRegions");
				}
			}								
			
			
			
			private Guid _GroupObjects;				    

						public Guid __GroupObjects 
			{
				get 
				{
					return _GroupObjects;
				}
				set
				{
					_GroupObjects = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef GroupObjects
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_GroupObjects", _GroupObjects);
									}
				set
				{
					base.OnPropertyChanging("GroupObjects");
					_GroupObjects = value.Id;
					base.OnPropertyChanged("GroupObjects");
				}
			}								
			
			
			
			private Guid _Users;				    

						public Guid __Users 
			{
				get 
				{
					return _Users;
				}
				set
				{
					_Users = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Users
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Users", _Users);
									}
				set
				{
					base.OnPropertyChanging("Users");
					_Users = value.Id;
					base.OnPropertyChanged("Users");
				}
			}								
			
			
			
			private System.Nullable<bool> _ObjectServices;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> ObjectServices 
			{
				get 
				{
					return _ObjectServices;
				}
				set 
				{
					base.OnPropertyChanging("ObjectServices");					
					_ObjectServices = value;
					base.OnPropertyChanged("ObjectServices");
				}
			}
			
			
			public static Object CreateInstance(OfflineContext dao)
            {
                Object entity = new Object();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<Object>(entity);
                return entity;
            }

						
			public System.Collections.Generic.IEnumerable<Catalog.Object_Comment> Comment(OfflineContext context) 
			{
				System.Collections.Generic.List<Catalog.Object_Comment> result = new System.Collections.Generic.List<Catalog.Object_Comment>();
				System.Collections.Generic.IEnumerable<Catalog.Object_Comment> items = context.GetCollection<Catalog.Object_Comment>();
				foreach(var item in items)
				{
					if(item.Ref.Equals(this.Id))
						result.Add(item);
				}
				return result;
			}

						
			public System.Collections.Generic.IEnumerable<Catalog.Object_Equipment> Equipment(OfflineContext context) 
			{
				System.Collections.Generic.List<Catalog.Object_Equipment> result = new System.Collections.Generic.List<Catalog.Object_Equipment>();
				System.Collections.Generic.IEnumerable<Catalog.Object_Equipment> items = context.GetCollection<Catalog.Object_Equipment>();
				foreach(var item in items)
				{
					if(item.Ref.Equals(this.Id))
						result.Add(item);
				}
				return result;
			}

						
			public System.Collections.Generic.IEnumerable<Catalog.Object_Features> Features(OfflineContext context) 
			{
				System.Collections.Generic.List<Catalog.Object_Features> result = new System.Collections.Generic.List<Catalog.Object_Features>();
				System.Collections.Generic.IEnumerable<Catalog.Object_Features> items = context.GetCollection<Catalog.Object_Features>();
				foreach(var item in items)
				{
					if(item.Ref.Equals(this.Id))
						result.Add(item);
				}
				return result;
			}

					}

		 

		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Object_Comment : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			Object _RefObject;

						
			private Guid _Id;	
			
						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Object_Comment", _Id);
																			}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
									
			private System.Nullable<int> _LineNumber;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<int> LineNumber 
			{
				get 
				{
					return _LineNumber;
				}
				set 
				{
					base.OnPropertyChanging("LineNumber");					
					_LineNumber = value;
					base.OnPropertyChanged("LineNumber");
				}
			}
									
			private String _Comment;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Comment 
			{
				get 
				{
					return _Comment;
				}
				set 
				{
					base.OnPropertyChanging("Comment");					
					_Comment = value;
					base.OnPropertyChanged("Comment");
				}
			}
									
			private Guid _Ref;	
			
						public Guid __Ref 
			{
				get 
				{
					return _Ref;
				}
				set
				{
					_Ref = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Ref
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Object", _Ref);
														}
				set
				{
					base.OnPropertyChanging("Ref");
					_Ref = value.Id;
					base.OnPropertyChanged("Ref");
				}
			}								
			
						
			public static Object_Comment CreateInstance(OfflineContext dao)
            {
                Object_Comment entity = new Object_Comment();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
				//dao.AddItem<Object_Comment>(entity);
                return entity;
            }
		}

		 

		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Object_Equipment : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			Object _RefObject;

						
			private Guid _Id;	
			
						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Object_Equipment", _Id);
																			}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
									
			private System.Nullable<int> _LineNumber;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<int> LineNumber 
			{
				get 
				{
					return _LineNumber;
				}
				set 
				{
					base.OnPropertyChanging("LineNumber");					
					_LineNumber = value;
					base.OnPropertyChanged("LineNumber");
				}
			}
									
			private Guid _Ref;	
			
						public Guid __Ref 
			{
				get 
				{
					return _Ref;
				}
				set
				{
					_Ref = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Ref
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Object", _Ref);
														}
				set
				{
					base.OnPropertyChanging("Ref");
					_Ref = value.Id;
					base.OnPropertyChanged("Ref");
				}
			}								
			
									
			private Guid _SKU;	
			
						public Guid __SKU 
			{
				get 
				{
					return _SKU;
				}
				set
				{
					_SKU = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef SKU
			{
				get
				{
																				return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_SKU", _SKU);
									}
				set
				{
					base.OnPropertyChanging("SKU");
					_SKU = value.Id;
					base.OnPropertyChanged("SKU");
				}
			}								
			
									
			private Guid _SerialNumber;	
			
						public Guid __SerialNumber 
			{
				get 
				{
					return _SerialNumber;
				}
				set
				{
					_SerialNumber = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef SerialNumber
			{
				get
				{
																				return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_SerialNumber", _SerialNumber);
									}
				set
				{
					base.OnPropertyChanging("SerialNumber");
					_SerialNumber = value.Id;
					base.OnPropertyChanged("SerialNumber");
				}
			}								
			
									
			private System.Nullable<decimal> _EquipmentCount;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<decimal> EquipmentCount 
			{
				get 
				{
					return _EquipmentCount;
				}
				set 
				{
					base.OnPropertyChanging("EquipmentCount");					
					_EquipmentCount = value;
					base.OnPropertyChanged("EquipmentCount");
				}
			}
						
			public static Object_Equipment CreateInstance(OfflineContext dao)
            {
                Object_Equipment entity = new Object_Equipment();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
				//dao.AddItem<Object_Equipment>(entity);
                return entity;
            }
		}

		 

		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Object_Features : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			Object _RefObject;

						
			private Guid _Id;	
			
						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Object_Features", _Id);
																			}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
									
			private System.Nullable<int> _LineNumber;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<int> LineNumber 
			{
				get 
				{
					return _LineNumber;
				}
				set 
				{
					base.OnPropertyChanging("LineNumber");					
					_LineNumber = value;
					base.OnPropertyChanged("LineNumber");
				}
			}
									
			private Guid _Ref;	
			
						public Guid __Ref 
			{
				get 
				{
					return _Ref;
				}
				set
				{
					_Ref = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Ref
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Object", _Ref);
														}
				set
				{
					base.OnPropertyChanging("Ref");
					_Ref = value.Id;
					base.OnPropertyChanged("Ref");
				}
			}								
			
						
			public static Object_Features CreateInstance(OfflineContext dao)
            {
                Object_Features entity = new Object_Features();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
				//dao.AddItem<Object_Features>(entity);
                return entity;
            }
		}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Contracts : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private System.Nullable<bool> _Predefined;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Predefined 
			{
				get 
				{
					return _Predefined;
				}
				set 
				{
					base.OnPropertyChanging("Predefined");					
					_Predefined = value;
					base.OnPropertyChanged("Predefined");
				}
			}
			
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Contracts", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private System.Nullable<bool> _DeletionMark;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DeletionMark 
			{
				get 
				{
					return _DeletionMark;
				}
				set 
				{
					base.OnPropertyChanging("DeletionMark");					
					_DeletionMark = value;
					base.OnPropertyChanged("DeletionMark");
				}
			}
			
			
			private System.Nullable<bool> _IsFolder;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> IsFolder 
			{
				get 
				{
					return _IsFolder;
				}
				set 
				{
					base.OnPropertyChanging("IsFolder");					
					_IsFolder = value;
					base.OnPropertyChanged("IsFolder");
				}
			}
			
			
			private Guid _Owner;				    

						public Guid __Owner 
			{
				get 
				{
					return _Owner;
				}
				set
				{
					_Owner = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Owner
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Counterparty", _Owner);
									}
				set
				{
					base.OnPropertyChanging("Owner");
					_Owner = value.Id;
					base.OnPropertyChanged("Owner");
				}
			}								
			
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			private String _Code;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Code 
			{
				get 
				{
					return _Code;
				}
				set 
				{
					base.OnPropertyChanging("Code");					
					_Code = value;
					base.OnPropertyChanged("Code");
				}
			}
			
			
			private Guid _TypesOfSettlement;				    

						public Guid __TypesOfSettlement 
			{
				get 
				{
					return _TypesOfSettlement;
				}
				set
				{
					_TypesOfSettlement = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef TypesOfSettlement
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_TypesOfSettlement", _TypesOfSettlement);
									}
				set
				{
					base.OnPropertyChanging("TypesOfSettlement");
					_TypesOfSettlement = value.Id;
					base.OnPropertyChanged("TypesOfSettlement");
				}
			}								
			
			
			
			private Guid _Org;				    

						public Guid __Org 
			{
				get 
				{
					return _Org;
				}
				set
				{
					_Org = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Org
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Org", _Org);
									}
				set
				{
					base.OnPropertyChanging("Org");
					_Org = value.Id;
					base.OnPropertyChanged("Org");
				}
			}								
			
			
			
			private System.Nullable<DateTime> _Date;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<DateTime> Date 
			{
				get 
				{
					return _Date;
				}
				set 
				{
					base.OnPropertyChanging("Date");					
					_Date = value;
					base.OnPropertyChanged("Date");
				}
			}
			
			
			private String _Numder;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Numder 
			{
				get 
				{
					return _Numder;
				}
				set 
				{
					base.OnPropertyChanging("Numder");					
					_Numder = value;
					base.OnPropertyChanged("Numder");
				}
			}
			
			
			private Guid _Object;				    

						public Guid __Object 
			{
				get 
				{
					return _Object;
				}
				set
				{
					_Object = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Object
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Object", _Object);
									}
				set
				{
					base.OnPropertyChanging("Object");
					_Object = value.Id;
					base.OnPropertyChanged("Object");
				}
			}								
			
			
			
			private Guid _TypeOfContract;				    

						public Guid __TypeOfContract 
			{
				get 
				{
					return _TypeOfContract;
				}
				set
				{
					_TypeOfContract = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef TypeOfContract
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Enum_TypeOfContract", _TypeOfContract);
									}
				set
				{
					base.OnPropertyChanging("TypeOfContract");
					_TypeOfContract = value.Id;
					base.OnPropertyChanged("TypeOfContract");
				}
			}								
			
			
			
			private Guid _TypeOfWork;				    

						public Guid __TypeOfWork 
			{
				get 
				{
					return _TypeOfWork;
				}
				set
				{
					_TypeOfWork = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef TypeOfWork
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_TypeOfWork", _TypeOfWork);
									}
				set
				{
					base.OnPropertyChanging("TypeOfWork");
					_TypeOfWork = value.Id;
					base.OnPropertyChanged("TypeOfWork");
				}
			}								
			
			
			
			public static Contracts CreateInstance(OfflineContext dao)
            {
                Contracts entity = new Contracts();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<Contracts>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Department : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private System.Nullable<bool> _Predefined;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Predefined 
			{
				get 
				{
					return _Predefined;
				}
				set 
				{
					base.OnPropertyChanging("Predefined");					
					_Predefined = value;
					base.OnPropertyChanged("Predefined");
				}
			}
			
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Department", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private System.Nullable<bool> _DeletionMark;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DeletionMark 
			{
				get 
				{
					return _DeletionMark;
				}
				set 
				{
					base.OnPropertyChanging("DeletionMark");					
					_DeletionMark = value;
					base.OnPropertyChanged("DeletionMark");
				}
			}
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			private String _Code;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Code 
			{
				get 
				{
					return _Code;
				}
				set 
				{
					base.OnPropertyChanging("Code");					
					_Code = value;
					base.OnPropertyChanged("Code");
				}
			}
			
			
			public static Department CreateInstance(OfflineContext dao)
            {
                Department entity = new Department();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<Department>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class IntervalService : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private System.Nullable<bool> _Predefined;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Predefined 
			{
				get 
				{
					return _Predefined;
				}
				set 
				{
					base.OnPropertyChanging("Predefined");					
					_Predefined = value;
					base.OnPropertyChanged("Predefined");
				}
			}
			
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_IntervalService", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private System.Nullable<bool> _DeletionMark;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DeletionMark 
			{
				get 
				{
					return _DeletionMark;
				}
				set 
				{
					base.OnPropertyChanging("DeletionMark");					
					_DeletionMark = value;
					base.OnPropertyChanged("DeletionMark");
				}
			}
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			private String _Code;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Code 
			{
				get 
				{
					return _Code;
				}
				set 
				{
					base.OnPropertyChanging("Code");					
					_Code = value;
					base.OnPropertyChanged("Code");
				}
			}
			
			
			private Guid _ObjectStatus;				    

						public Guid __ObjectStatus 
			{
				get 
				{
					return _ObjectStatus;
				}
				set
				{
					_ObjectStatus = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef ObjectStatus
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Enum_ObjectStatus", _ObjectStatus);
									}
				set
				{
					base.OnPropertyChanging("ObjectStatus");
					_ObjectStatus = value.Id;
					base.OnPropertyChanged("ObjectStatus");
				}
			}								
			
			
			
			private System.Nullable<DateTime> _DateApproval;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<DateTime> DateApproval 
			{
				get 
				{
					return _DateApproval;
				}
				set 
				{
					base.OnPropertyChanging("DateApproval");					
					_DateApproval = value;
					base.OnPropertyChanged("DateApproval");
				}
			}
			
			
			private Guid _Periodicity;				    

						public Guid __Periodicity 
			{
				get 
				{
					return _Periodicity;
				}
				set
				{
					_Periodicity = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Periodicity
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Enum_Periodicity", _Periodicity);
									}
				set
				{
					base.OnPropertyChanging("Periodicity");
					_Periodicity = value.Id;
					base.OnPropertyChanged("Periodicity");
				}
			}								
			
			
			
			private System.Nullable<decimal> _PeriodCount;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<decimal> PeriodCount 
			{
				get 
				{
					return _PeriodCount;
				}
				set 
				{
					base.OnPropertyChanging("PeriodCount");					
					_PeriodCount = value;
					base.OnPropertyChanged("PeriodCount");
				}
			}
			
			
			private System.Nullable<decimal> _Count;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<decimal> Count 
			{
				get 
				{
					return _Count;
				}
				set 
				{
					base.OnPropertyChanging("Count");					
					_Count = value;
					base.OnPropertyChanged("Count");
				}
			}
			
			
			public static IntervalService CreateInstance(OfflineContext dao)
            {
                IntervalService entity = new IntervalService();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<IntervalService>(entity);
                return entity;
            }

						
			public System.Collections.Generic.IEnumerable<Catalog.IntervalService_Comment> Comment(OfflineContext context) 
			{
				System.Collections.Generic.List<Catalog.IntervalService_Comment> result = new System.Collections.Generic.List<Catalog.IntervalService_Comment>();
				System.Collections.Generic.IEnumerable<Catalog.IntervalService_Comment> items = context.GetCollection<Catalog.IntervalService_Comment>();
				foreach(var item in items)
				{
					if(item.Ref.Equals(this.Id))
						result.Add(item);
				}
				return result;
			}

					}

		 

		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class IntervalService_Comment : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			IntervalService _RefObject;

						
			private Guid _Id;	
			
						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_IntervalService_Comment", _Id);
																			}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
									
			private System.Nullable<int> _LineNumber;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<int> LineNumber 
			{
				get 
				{
					return _LineNumber;
				}
				set 
				{
					base.OnPropertyChanging("LineNumber");					
					_LineNumber = value;
					base.OnPropertyChanged("LineNumber");
				}
			}
									
			private String _Comment;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Comment 
			{
				get 
				{
					return _Comment;
				}
				set 
				{
					base.OnPropertyChanging("Comment");					
					_Comment = value;
					base.OnPropertyChanged("Comment");
				}
			}
									
			private Guid _Ref;	
			
						public Guid __Ref 
			{
				get 
				{
					return _Ref;
				}
				set
				{
					_Ref = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Ref
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_IntervalService", _Ref);
														}
				set
				{
					base.OnPropertyChanging("Ref");
					_Ref = value.Id;
					base.OnPropertyChanged("Ref");
				}
			}								
			
						
			public static IntervalService_Comment CreateInstance(OfflineContext dao)
            {
                IntervalService_Comment entity = new IntervalService_Comment();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
				//dao.AddItem<IntervalService_Comment>(entity);
                return entity;
            }
		}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Unit : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private System.Nullable<bool> _Predefined;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Predefined 
			{
				get 
				{
					return _Predefined;
				}
				set 
				{
					base.OnPropertyChanging("Predefined");					
					_Predefined = value;
					base.OnPropertyChanged("Predefined");
				}
			}
			
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Unit", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private System.Nullable<bool> _DeletionMark;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DeletionMark 
			{
				get 
				{
					return _DeletionMark;
				}
				set 
				{
					base.OnPropertyChanging("DeletionMark");					
					_DeletionMark = value;
					base.OnPropertyChanged("DeletionMark");
				}
			}
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			private String _Code;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Code 
			{
				get 
				{
					return _Code;
				}
				set 
				{
					base.OnPropertyChanging("Code");					
					_Code = value;
					base.OnPropertyChanged("Code");
				}
			}
			
			
			public static Unit CreateInstance(OfflineContext dao)
            {
                Unit entity = new Unit();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<Unit>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class SKU : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private System.Nullable<bool> _Predefined;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Predefined 
			{
				get 
				{
					return _Predefined;
				}
				set 
				{
					base.OnPropertyChanging("Predefined");					
					_Predefined = value;
					base.OnPropertyChanged("Predefined");
				}
			}
			
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_SKU", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private System.Nullable<bool> _DeletionMark;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DeletionMark 
			{
				get 
				{
					return _DeletionMark;
				}
				set 
				{
					base.OnPropertyChanging("DeletionMark");					
					_DeletionMark = value;
					base.OnPropertyChanged("DeletionMark");
				}
			}
			
			
			private System.Nullable<bool> _IsFolder;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> IsFolder 
			{
				get 
				{
					return _IsFolder;
				}
				set 
				{
					base.OnPropertyChanging("IsFolder");					
					_IsFolder = value;
					base.OnPropertyChanged("IsFolder");
				}
			}
			
			
			private Guid _Parent;				    

						public Guid __Parent 
			{
				get 
				{
					return _Parent;
				}
				set
				{
					_Parent = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Parent
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_SKU", _Parent);
									}
				set
				{
					base.OnPropertyChanging("Parent");
					_Parent = value.Id;
					base.OnPropertyChanged("Parent");
				}
			}								
			
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			private String _Code;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Code 
			{
				get 
				{
					return _Code;
				}
				set 
				{
					base.OnPropertyChanging("Code");					
					_Code = value;
					base.OnPropertyChanged("Code");
				}
			}
			
			
			private Guid _Unit;				    

						public Guid __Unit 
			{
				get 
				{
					return _Unit;
				}
				set
				{
					_Unit = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Unit
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Unit", _Unit);
									}
				set
				{
					base.OnPropertyChanging("Unit");
					_Unit = value.Id;
					base.OnPropertyChanged("Unit");
				}
			}								
			
			
			
			private System.Nullable<bool> _Service;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Service 
			{
				get 
				{
					return _Service;
				}
				set 
				{
					base.OnPropertyChanging("Service");					
					_Service = value;
					base.OnPropertyChanged("Service");
				}
			}
			
			
			private System.Nullable<bool> _UsedInBitmobile;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> UsedInBitmobile 
			{
				get 
				{
					return _UsedInBitmobile;
				}
				set 
				{
					base.OnPropertyChanging("UsedInBitmobile");					
					_UsedInBitmobile = value;
					base.OnPropertyChanged("UsedInBitmobile");
				}
			}
			
			
			public static SKU CreateInstance(OfflineContext dao)
            {
                SKU entity = new SKU();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<SKU>(entity);
                return entity;
            }

						
			public System.Collections.Generic.IEnumerable<Catalog.SKU_Stocks> Stocks(OfflineContext context) 
			{
				System.Collections.Generic.List<Catalog.SKU_Stocks> result = new System.Collections.Generic.List<Catalog.SKU_Stocks>();
				System.Collections.Generic.IEnumerable<Catalog.SKU_Stocks> items = context.GetCollection<Catalog.SKU_Stocks>();
				foreach(var item in items)
				{
					if(item.Ref.Equals(this.Id))
						result.Add(item);
				}
				return result;
			}

						
			public System.Collections.Generic.IEnumerable<Catalog.SKU_Limits> Limits(OfflineContext context) 
			{
				System.Collections.Generic.List<Catalog.SKU_Limits> result = new System.Collections.Generic.List<Catalog.SKU_Limits>();
				System.Collections.Generic.IEnumerable<Catalog.SKU_Limits> items = context.GetCollection<Catalog.SKU_Limits>();
				foreach(var item in items)
				{
					if(item.Ref.Equals(this.Id))
						result.Add(item);
				}
				return result;
			}

					}

		 

		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class SKU_Stocks : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			SKU _RefObject;

						
			private Guid _Id;	
			
						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_SKU_Stocks", _Id);
																			}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
									
			private System.Nullable<int> _LineNumber;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<int> LineNumber 
			{
				get 
				{
					return _LineNumber;
				}
				set 
				{
					base.OnPropertyChanging("LineNumber");					
					_LineNumber = value;
					base.OnPropertyChanged("LineNumber");
				}
			}
									
			private Guid _Ref;	
			
						public Guid __Ref 
			{
				get 
				{
					return _Ref;
				}
				set
				{
					_Ref = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Ref
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_SKU", _Ref);
														}
				set
				{
					base.OnPropertyChanging("Ref");
					_Ref = value.Id;
					base.OnPropertyChanged("Ref");
				}
			}								
			
									
			private Guid _Sklad;	
			
						public Guid __Sklad 
			{
				get 
				{
					return _Sklad;
				}
				set
				{
					_Sklad = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Sklad
			{
				get
				{
																				return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Sklad", _Sklad);
									}
				set
				{
					base.OnPropertyChanging("Sklad");
					_Sklad = value.Id;
					base.OnPropertyChanged("Sklad");
				}
			}								
			
									
			private System.Nullable<decimal> _Count;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<decimal> Count 
			{
				get 
				{
					return _Count;
				}
				set 
				{
					base.OnPropertyChanging("Count");					
					_Count = value;
					base.OnPropertyChanged("Count");
				}
			}
						
			public static SKU_Stocks CreateInstance(OfflineContext dao)
            {
                SKU_Stocks entity = new SKU_Stocks();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
				//dao.AddItem<SKU_Stocks>(entity);
                return entity;
            }
		}

		 

		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class SKU_Limits : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			SKU _RefObject;

						
			private Guid _Id;	
			
						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_SKU_Limits", _Id);
																			}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
									
			private System.Nullable<int> _LineNumber;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<int> LineNumber 
			{
				get 
				{
					return _LineNumber;
				}
				set 
				{
					base.OnPropertyChanging("LineNumber");					
					_LineNumber = value;
					base.OnPropertyChanged("LineNumber");
				}
			}
									
			private Guid _Ref;	
			
						public Guid __Ref 
			{
				get 
				{
					return _Ref;
				}
				set
				{
					_Ref = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Ref
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_SKU", _Ref);
														}
				set
				{
					base.OnPropertyChanging("Ref");
					_Ref = value.Id;
					base.OnPropertyChanged("Ref");
				}
			}								
			
									
			private Guid _Sklad;	
			
						public Guid __Sklad 
			{
				get 
				{
					return _Sklad;
				}
				set
				{
					_Sklad = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Sklad
			{
				get
				{
																				return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Sklad", _Sklad);
									}
				set
				{
					base.OnPropertyChanging("Sklad");
					_Sklad = value.Id;
					base.OnPropertyChanged("Sklad");
				}
			}								
			
									
			private System.Nullable<decimal> _Count;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<decimal> Count 
			{
				get 
				{
					return _Count;
				}
				set 
				{
					base.OnPropertyChanging("Count");					
					_Count = value;
					base.OnPropertyChanged("Count");
				}
			}
						
			public static SKU_Limits CreateInstance(OfflineContext dao)
            {
                SKU_Limits entity = new SKU_Limits();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
				//dao.AddItem<SKU_Limits>(entity);
                return entity;
            }
		}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class SerialNumber : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private System.Nullable<bool> _Predefined;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Predefined 
			{
				get 
				{
					return _Predefined;
				}
				set 
				{
					base.OnPropertyChanging("Predefined");					
					_Predefined = value;
					base.OnPropertyChanged("Predefined");
				}
			}
			
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_SerialNumber", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private System.Nullable<bool> _DeletionMark;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DeletionMark 
			{
				get 
				{
					return _DeletionMark;
				}
				set 
				{
					base.OnPropertyChanging("DeletionMark");					
					_DeletionMark = value;
					base.OnPropertyChanged("DeletionMark");
				}
			}
			
			
			private Guid _Owner;				    

						public Guid __Owner 
			{
				get 
				{
					return _Owner;
				}
				set
				{
					_Owner = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Owner
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_SKU", _Owner);
									}
				set
				{
					base.OnPropertyChanging("Owner");
					_Owner = value.Id;
					base.OnPropertyChanged("Owner");
				}
			}								
			
			
			
			private String _Code;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Code 
			{
				get 
				{
					return _Code;
				}
				set 
				{
					base.OnPropertyChanging("Code");					
					_Code = value;
					base.OnPropertyChanged("Code");
				}
			}
			
			
			public static SerialNumber CreateInstance(OfflineContext dao)
            {
                SerialNumber entity = new SerialNumber();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<SerialNumber>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Person : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private System.Nullable<bool> _Predefined;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Predefined 
			{
				get 
				{
					return _Predefined;
				}
				set 
				{
					base.OnPropertyChanging("Predefined");					
					_Predefined = value;
					base.OnPropertyChanged("Predefined");
				}
			}
			
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Person", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private System.Nullable<bool> _DeletionMark;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DeletionMark 
			{
				get 
				{
					return _DeletionMark;
				}
				set 
				{
					base.OnPropertyChanging("DeletionMark");					
					_DeletionMark = value;
					base.OnPropertyChanged("DeletionMark");
				}
			}
			
			
			private System.Nullable<bool> _IsFolder;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> IsFolder 
			{
				get 
				{
					return _IsFolder;
				}
				set 
				{
					base.OnPropertyChanging("IsFolder");					
					_IsFolder = value;
					base.OnPropertyChanged("IsFolder");
				}
			}
			
			
			private Guid _Parent;				    

						public Guid __Parent 
			{
				get 
				{
					return _Parent;
				}
				set
				{
					_Parent = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Parent
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Person", _Parent);
									}
				set
				{
					base.OnPropertyChanging("Parent");
					_Parent = value.Id;
					base.OnPropertyChanged("Parent");
				}
			}								
			
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			private String _Code;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Code 
			{
				get 
				{
					return _Code;
				}
				set 
				{
					base.OnPropertyChanging("Code");					
					_Code = value;
					base.OnPropertyChanged("Code");
				}
			}
			
			
			private Guid _ObjectContactName;				    

						public Guid __ObjectContactName 
			{
				get 
				{
					return _ObjectContactName;
				}
				set
				{
					_ObjectContactName = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef ObjectContactName
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_ObjectContactName", _ObjectContactName);
									}
				set
				{
					base.OnPropertyChanging("ObjectContactName");
					_ObjectContactName = value.Id;
					base.OnPropertyChanged("ObjectContactName");
				}
			}								
			
			
			
			private Guid _Org;				    

						public Guid __Org 
			{
				get 
				{
					return _Org;
				}
				set
				{
					_Org = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Org
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Org", _Org);
									}
				set
				{
					base.OnPropertyChanging("Org");
					_Org = value.Id;
					base.OnPropertyChanged("Org");
				}
			}								
			
			
			
			private Guid _Department;				    

						public Guid __Department 
			{
				get 
				{
					return _Department;
				}
				set
				{
					_Department = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Department
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Department", _Department);
									}
				set
				{
					base.OnPropertyChanging("Department");
					_Department = value.Id;
					base.OnPropertyChanged("Department");
				}
			}								
			
			
			
			private Guid _ContactPosition;				    

						public Guid __ContactPosition 
			{
				get 
				{
					return _ContactPosition;
				}
				set
				{
					_ContactPosition = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef ContactPosition
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_ContactPosition", _ContactPosition);
									}
				set
				{
					base.OnPropertyChanging("ContactPosition");
					_ContactPosition = value.Id;
					base.OnPropertyChanged("ContactPosition");
				}
			}								
			
			
			
			public static Person CreateInstance(OfflineContext dao)
            {
                Person entity = new Person();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<Person>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Sklad : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private System.Nullable<bool> _Predefined;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Predefined 
			{
				get 
				{
					return _Predefined;
				}
				set 
				{
					base.OnPropertyChanging("Predefined");					
					_Predefined = value;
					base.OnPropertyChanged("Predefined");
				}
			}
			
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Sklad", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private System.Nullable<bool> _DeletionMark;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DeletionMark 
			{
				get 
				{
					return _DeletionMark;
				}
				set 
				{
					base.OnPropertyChanging("DeletionMark");					
					_DeletionMark = value;
					base.OnPropertyChanged("DeletionMark");
				}
			}
			
			
			private System.Nullable<bool> _IsFolder;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> IsFolder 
			{
				get 
				{
					return _IsFolder;
				}
				set 
				{
					base.OnPropertyChanging("IsFolder");					
					_IsFolder = value;
					base.OnPropertyChanged("IsFolder");
				}
			}
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			private String _Code;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Code 
			{
				get 
				{
					return _Code;
				}
				set 
				{
					base.OnPropertyChanging("Code");					
					_Code = value;
					base.OnPropertyChanged("Code");
				}
			}
			
			
			public static Sklad CreateInstance(OfflineContext dao)
            {
                Sklad entity = new Sklad();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<Sklad>(entity);
                return entity;
            }

						
			public System.Collections.Generic.IEnumerable<Catalog.Sklad_Department> Department(OfflineContext context) 
			{
				System.Collections.Generic.List<Catalog.Sklad_Department> result = new System.Collections.Generic.List<Catalog.Sklad_Department>();
				System.Collections.Generic.IEnumerable<Catalog.Sklad_Department> items = context.GetCollection<Catalog.Sklad_Department>();
				foreach(var item in items)
				{
					if(item.Ref.Equals(this.Id))
						result.Add(item);
				}
				return result;
			}

					}

		 

		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Sklad_Department : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			Sklad _RefObject;

						
			private Guid _Id;	
			
						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Sklad_Department", _Id);
																			}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
									
			private System.Nullable<int> _LineNumber;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<int> LineNumber 
			{
				get 
				{
					return _LineNumber;
				}
				set 
				{
					base.OnPropertyChanging("LineNumber");					
					_LineNumber = value;
					base.OnPropertyChanged("LineNumber");
				}
			}
									
			private Guid _Depart;	
			
						public Guid __Depart 
			{
				get 
				{
					return _Depart;
				}
				set
				{
					_Depart = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Depart
			{
				get
				{
																				return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Department", _Depart);
									}
				set
				{
					base.OnPropertyChanging("Depart");
					_Depart = value.Id;
					base.OnPropertyChanged("Depart");
				}
			}								
			
									
			private Guid _Ref;	
			
						public Guid __Ref 
			{
				get 
				{
					return _Ref;
				}
				set
				{
					_Ref = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Ref
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Sklad", _Ref);
														}
				set
				{
					base.OnPropertyChanging("Ref");
					_Ref = value.Id;
					base.OnPropertyChanged("Ref");
				}
			}								
			
						
			public static Sklad_Department CreateInstance(OfflineContext dao)
            {
                Sklad_Department entity = new Sklad_Department();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
				//dao.AddItem<Sklad_Department>(entity);
                return entity;
            }
		}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class TypesService : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private System.Nullable<bool> _Predefined;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Predefined 
			{
				get 
				{
					return _Predefined;
				}
				set 
				{
					base.OnPropertyChanging("Predefined");					
					_Predefined = value;
					base.OnPropertyChanged("Predefined");
				}
			}
			
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_TypesService", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private System.Nullable<bool> _DeletionMark;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DeletionMark 
			{
				get 
				{
					return _DeletionMark;
				}
				set 
				{
					base.OnPropertyChanging("DeletionMark");					
					_DeletionMark = value;
					base.OnPropertyChanged("DeletionMark");
				}
			}
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			private String _Code;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Code 
			{
				get 
				{
					return _Code;
				}
				set 
				{
					base.OnPropertyChanging("Code");					
					_Code = value;
					base.OnPropertyChanged("Code");
				}
			}
			
			
			public static TypesService CreateInstance(OfflineContext dao)
            {
                TypesService entity = new TypesService();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<TypesService>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class UnitCat : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private System.Nullable<bool> _Predefined;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Predefined 
			{
				get 
				{
					return _Predefined;
				}
				set 
				{
					base.OnPropertyChanging("Predefined");					
					_Predefined = value;
					base.OnPropertyChanged("Predefined");
				}
			}
			
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_UnitCat", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private System.Nullable<bool> _DeletionMark;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DeletionMark 
			{
				get 
				{
					return _DeletionMark;
				}
				set 
				{
					base.OnPropertyChanging("DeletionMark");					
					_DeletionMark = value;
					base.OnPropertyChanged("DeletionMark");
				}
			}
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			private String _Code;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Code 
			{
				get 
				{
					return _Code;
				}
				set 
				{
					base.OnPropertyChanging("Code");					
					_Code = value;
					base.OnPropertyChanged("Code");
				}
			}
			
			
			public static UnitCat CreateInstance(OfflineContext dao)
            {
                UnitCat entity = new UnitCat();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<UnitCat>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class User : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private System.Nullable<bool> _Predefined;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Predefined 
			{
				get 
				{
					return _Predefined;
				}
				set 
				{
					base.OnPropertyChanging("Predefined");					
					_Predefined = value;
					base.OnPropertyChanged("Predefined");
				}
			}
			
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_User", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private System.Nullable<bool> _DeletionMark;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DeletionMark 
			{
				get 
				{
					return _DeletionMark;
				}
				set 
				{
					base.OnPropertyChanging("DeletionMark");					
					_DeletionMark = value;
					base.OnPropertyChanged("DeletionMark");
				}
			}
			
			
			private System.Nullable<bool> _IsFolder;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> IsFolder 
			{
				get 
				{
					return _IsFolder;
				}
				set 
				{
					base.OnPropertyChanging("IsFolder");					
					_IsFolder = value;
					base.OnPropertyChanged("IsFolder");
				}
			}
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			private String _Code;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Code 
			{
				get 
				{
					return _Code;
				}
				set 
				{
					base.OnPropertyChanging("Code");					
					_Code = value;
					base.OnPropertyChanged("Code");
				}
			}
			
			
			private String _UserName;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String UserName 
			{
				get 
				{
					return _UserName;
				}
				set 
				{
					base.OnPropertyChanging("UserName");					
					_UserName = value;
					base.OnPropertyChanged("UserName");
				}
			}
			
			
			private String _Password;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Password 
			{
				get 
				{
					return _Password;
				}
				set 
				{
					base.OnPropertyChanging("Password");					
					_Password = value;
					base.OnPropertyChanged("Password");
				}
			}
			
			
			private String _Role;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Role 
			{
				get 
				{
					return _Role;
				}
				set 
				{
					base.OnPropertyChanging("Role");					
					_Role = value;
					base.OnPropertyChanged("Role");
				}
			}
			
			
			private String _EMail;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String EMail 
			{
				get 
				{
					return _EMail;
				}
				set 
				{
					base.OnPropertyChanging("EMail");					
					_EMail = value;
					base.OnPropertyChanged("EMail");
				}
			}
			
			
			private Guid _Department;				    

						public Guid __Department 
			{
				get 
				{
					return _Department;
				}
				set
				{
					_Department = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Department
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Department", _Department);
									}
				set
				{
					base.OnPropertyChanging("Department");
					_Department = value.Id;
					base.OnPropertyChanged("Department");
				}
			}								
			
			
			
			public static User CreateInstance(OfflineContext dao)
            {
                User entity = new User();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<User>(entity);
                return entity;
            }

					}

		        
		
		public class Collections
		{
			private OfflineContext context;

			public Collections(OfflineContext context)
			{
				this.context = context;
			}

			 

			public System.Collections.Generic.IEnumerable<Catalog.Counterparty> Counterparty 
			{
				get 
				{
					return context.GetCollection<Catalog.Counterparty>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<Catalog.ContactName> ContactName 
			{
				get 
				{
					return context.GetCollection<Catalog.ContactName>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<Catalog.ContactPosition> ContactPosition 
			{
				get 
				{
					return context.GetCollection<Catalog.ContactPosition>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<Catalog.TypesOfSettlement> TypesOfSettlement 
			{
				get 
				{
					return context.GetCollection<Catalog.TypesOfSettlement>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<Catalog.TypeOfWork> TypeOfWork 
			{
				get 
				{
					return context.GetCollection<Catalog.TypeOfWork>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<Catalog.Org> Org 
			{
				get 
				{
					return context.GetCollection<Catalog.Org>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<Catalog.Users> Users 
			{
				get 
				{
					return context.GetCollection<Catalog.Users>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<Catalog.ObjectContactName> ObjectContactName 
			{
				get 
				{
					return context.GetCollection<Catalog.ObjectContactName>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<Catalog.GroupObjects> GroupObjects 
			{
				get 
				{
					return context.GetCollection<Catalog.GroupObjects>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<Catalog.DutyRegions> DutyRegions 
			{
				get 
				{
					return context.GetCollection<Catalog.DutyRegions>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<Catalog.Object> Object 
			{
				get 
				{
					return context.GetCollection<Catalog.Object>();
				}
			}


			 
			
			public System.Collections.Generic.IEnumerable<Catalog.Object_Comment> Object_Comment 
			{
				get 
				{
					return context.GetCollection<Catalog.Object_Comment>();
				}
			}
			
			 
			
			public System.Collections.Generic.IEnumerable<Catalog.Object_Equipment> Object_Equipment 
			{
				get 
				{
					return context.GetCollection<Catalog.Object_Equipment>();
				}
			}
			
			 
			
			public System.Collections.Generic.IEnumerable<Catalog.Object_Features> Object_Features 
			{
				get 
				{
					return context.GetCollection<Catalog.Object_Features>();
				}
			}
			
			
			 

			public System.Collections.Generic.IEnumerable<Catalog.Contracts> Contracts 
			{
				get 
				{
					return context.GetCollection<Catalog.Contracts>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<Catalog.Department> Department 
			{
				get 
				{
					return context.GetCollection<Catalog.Department>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<Catalog.IntervalService> IntervalService 
			{
				get 
				{
					return context.GetCollection<Catalog.IntervalService>();
				}
			}


			 
			
			public System.Collections.Generic.IEnumerable<Catalog.IntervalService_Comment> IntervalService_Comment 
			{
				get 
				{
					return context.GetCollection<Catalog.IntervalService_Comment>();
				}
			}
			
			
			 

			public System.Collections.Generic.IEnumerable<Catalog.Unit> Unit 
			{
				get 
				{
					return context.GetCollection<Catalog.Unit>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<Catalog.SKU> SKU 
			{
				get 
				{
					return context.GetCollection<Catalog.SKU>();
				}
			}


			 
			
			public System.Collections.Generic.IEnumerable<Catalog.SKU_Stocks> SKU_Stocks 
			{
				get 
				{
					return context.GetCollection<Catalog.SKU_Stocks>();
				}
			}
			
			 
			
			public System.Collections.Generic.IEnumerable<Catalog.SKU_Limits> SKU_Limits 
			{
				get 
				{
					return context.GetCollection<Catalog.SKU_Limits>();
				}
			}
			
			
			 

			public System.Collections.Generic.IEnumerable<Catalog.SerialNumber> SerialNumber 
			{
				get 
				{
					return context.GetCollection<Catalog.SerialNumber>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<Catalog.Person> Person 
			{
				get 
				{
					return context.GetCollection<Catalog.Person>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<Catalog.Sklad> Sklad 
			{
				get 
				{
					return context.GetCollection<Catalog.Sklad>();
				}
			}


			 
			
			public System.Collections.Generic.IEnumerable<Catalog.Sklad_Department> Sklad_Department 
			{
				get 
				{
					return context.GetCollection<Catalog.Sklad_Department>();
				}
			}
			
			
			 

			public System.Collections.Generic.IEnumerable<Catalog.TypesService> TypesService 
			{
				get 
				{
					return context.GetCollection<Catalog.TypesService>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<Catalog.UnitCat> UnitCat 
			{
				get 
				{
					return context.GetCollection<Catalog.UnitCat>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<Catalog.User> User 
			{
				get 
				{
					return context.GetCollection<Catalog.User>();
				}
			}


			
					}

	}

	 
	namespace Document 
	{
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Task : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private System.Nullable<bool> _Posted;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Posted 
			{
				get 
				{
					return _Posted;
				}
				set 
				{
					base.OnPropertyChanging("Posted");					
					_Posted = value;
					base.OnPropertyChanged("Posted");
				}
			}
			
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Document_Task", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private System.Nullable<bool> _DeletionMark;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DeletionMark 
			{
				get 
				{
					return _DeletionMark;
				}
				set 
				{
					base.OnPropertyChanging("DeletionMark");					
					_DeletionMark = value;
					base.OnPropertyChanged("DeletionMark");
				}
			}
			
			
			private DateTime _Date;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public DateTime Date 
			{
				get 
				{
					return _Date;
				}
				set 
				{
					base.OnPropertyChanging("Date");					
					_Date = value;
					base.OnPropertyChanged("Date");
				}
			}
			
			
			private String _Number;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Number 
			{
				get 
				{
					return _Number;
				}
				set 
				{
					base.OnPropertyChanging("Number");					
					_Number = value;
					base.OnPropertyChanged("Number");
				}
			}
			
			
			private Guid _Org;				    

						public Guid __Org 
			{
				get 
				{
					return _Org;
				}
				set
				{
					_Org = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Org
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Org", _Org);
									}
				set
				{
					base.OnPropertyChanging("Org");
					_Org = value.Id;
					base.OnPropertyChanged("Org");
				}
			}								
			
			
			
			private Guid _Counterparty;				    

						public Guid __Counterparty 
			{
				get 
				{
					return _Counterparty;
				}
				set
				{
					_Counterparty = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Counterparty
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Counterparty", _Counterparty);
									}
				set
				{
					base.OnPropertyChanging("Counterparty");
					_Counterparty = value.Id;
					base.OnPropertyChanged("Counterparty");
				}
			}								
			
			
			
			private Guid _Object;				    

						public Guid __Object 
			{
				get 
				{
					return _Object;
				}
				set
				{
					_Object = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Object
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Object", _Object);
									}
				set
				{
					base.OnPropertyChanging("Object");
					_Object = value.Id;
					base.OnPropertyChanged("Object");
				}
			}								
			
			
			
			private System.Nullable<DateTime> _TimeStart;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<DateTime> TimeStart 
			{
				get 
				{
					return _TimeStart;
				}
				set 
				{
					base.OnPropertyChanging("TimeStart");					
					_TimeStart = value;
					base.OnPropertyChanged("TimeStart");
				}
			}
			
			
			private System.Nullable<decimal> _TimeSpent;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<decimal> TimeSpent 
			{
				get 
				{
					return _TimeSpent;
				}
				set 
				{
					base.OnPropertyChanging("TimeSpent");					
					_TimeSpent = value;
					base.OnPropertyChanged("TimeSpent");
				}
			}
			
			
			private System.Nullable<DateTime> _TimeFinish;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<DateTime> TimeFinish 
			{
				get 
				{
					return _TimeFinish;
				}
				set 
				{
					base.OnPropertyChanging("TimeFinish");					
					_TimeFinish = value;
					base.OnPropertyChanged("TimeFinish");
				}
			}
			
			
			private System.Nullable<decimal> _TimeReactionNorm;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<decimal> TimeReactionNorm 
			{
				get 
				{
					return _TimeReactionNorm;
				}
				set 
				{
					base.OnPropertyChanging("TimeReactionNorm");					
					_TimeReactionNorm = value;
					base.OnPropertyChanged("TimeReactionNorm");
				}
			}
			
			
			private System.Nullable<decimal> _TimeRepairNorm;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<decimal> TimeRepairNorm 
			{
				get 
				{
					return _TimeRepairNorm;
				}
				set 
				{
					base.OnPropertyChanging("TimeRepairNorm");					
					_TimeRepairNorm = value;
					base.OnPropertyChanged("TimeRepairNorm");
				}
			}
			
			
			private Guid _Users;				    

						public Guid __Users 
			{
				get 
				{
					return _Users;
				}
				set
				{
					_Users = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Users
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Users", _Users);
									}
				set
				{
					base.OnPropertyChanging("Users");
					_Users = value.Id;
					base.OnPropertyChanged("Users");
				}
			}								
			
			
			
			private Guid _Department;				    

						public Guid __Department 
			{
				get 
				{
					return _Department;
				}
				set
				{
					_Department = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Department
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Department", _Department);
									}
				set
				{
					base.OnPropertyChanging("Department");
					_Department = value.Id;
					base.OnPropertyChanged("Department");
				}
			}								
			
			
			
			private Guid _ContactName;				    

						public Guid __ContactName 
			{
				get 
				{
					return _ContactName;
				}
				set
				{
					_ContactName = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef ContactName
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_ContactName", _ContactName);
									}
				set
				{
					base.OnPropertyChanging("ContactName");
					_ContactName = value.Id;
					base.OnPropertyChanged("ContactName");
				}
			}								
			
			
			
			private Guid _StatusTasks;				    

						public Guid __StatusTasks 
			{
				get 
				{
					return _StatusTasks;
				}
				set
				{
					_StatusTasks = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef StatusTasks
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Enum_StatusTasks", _StatusTasks);
									}
				set
				{
					base.OnPropertyChanging("StatusTasks");
					_StatusTasks = value.Id;
					base.OnPropertyChanged("StatusTasks");
				}
			}								
			
			
			
			private Guid _ViewTasks;				    

						public Guid __ViewTasks 
			{
				get 
				{
					return _ViewTasks;
				}
				set
				{
					_ViewTasks = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef ViewTasks
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Enum_ViewTasks", _ViewTasks);
									}
				set
				{
					base.OnPropertyChanging("ViewTasks");
					_ViewTasks = value.Id;
					base.OnPropertyChanged("ViewTasks");
				}
			}								
			
			
			
			private Guid _TypesService;				    

						public Guid __TypesService 
			{
				get 
				{
					return _TypesService;
				}
				set
				{
					_TypesService = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef TypesService
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_TypesService", _TypesService);
									}
				set
				{
					base.OnPropertyChanging("TypesService");
					_TypesService = value.Id;
					base.OnPropertyChanged("TypesService");
				}
			}								
			
			
			
			public static Task CreateInstance(OfflineContext dao)
            {
                Task entity = new Task();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<Task>(entity);
                return entity;
            }

						
			public System.Collections.Generic.IEnumerable<Document.Task_Comment> Comment(OfflineContext context) 
			{
				System.Collections.Generic.List<Document.Task_Comment> result = new System.Collections.Generic.List<Document.Task_Comment>();
				System.Collections.Generic.IEnumerable<Document.Task_Comment> items = context.GetCollection<Document.Task_Comment>();
				foreach(var item in items)
				{
					if(item.Ref.Equals(this.Id))
						result.Add(item);
				}
				return result;
			}

						
			public System.Collections.Generic.IEnumerable<Document.Task_Problem> Problem(OfflineContext context) 
			{
				System.Collections.Generic.List<Document.Task_Problem> result = new System.Collections.Generic.List<Document.Task_Problem>();
				System.Collections.Generic.IEnumerable<Document.Task_Problem> items = context.GetCollection<Document.Task_Problem>();
				foreach(var item in items)
				{
					if(item.Ref.Equals(this.Id))
						result.Add(item);
				}
				return result;
			}

						
			public System.Collections.Generic.IEnumerable<Document.Task_ContactTel> ContactTel(OfflineContext context) 
			{
				System.Collections.Generic.List<Document.Task_ContactTel> result = new System.Collections.Generic.List<Document.Task_ContactTel>();
				System.Collections.Generic.IEnumerable<Document.Task_ContactTel> items = context.GetCollection<Document.Task_ContactTel>();
				foreach(var item in items)
				{
					if(item.Ref.Equals(this.Id))
						result.Add(item);
				}
				return result;
			}

					}

		 

		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Task_Comment : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			Task _RefObject;

						
			private Guid _Id;	
			
						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Document_Task_Comment", _Id);
																			}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
									
			private System.Nullable<int> _LineNumber;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<int> LineNumber 
			{
				get 
				{
					return _LineNumber;
				}
				set 
				{
					base.OnPropertyChanging("LineNumber");					
					_LineNumber = value;
					base.OnPropertyChanged("LineNumber");
				}
			}
									
			private String _Comment;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Comment 
			{
				get 
				{
					return _Comment;
				}
				set 
				{
					base.OnPropertyChanging("Comment");					
					_Comment = value;
					base.OnPropertyChanged("Comment");
				}
			}
									
			private Guid _Ref;	
			
						public Guid __Ref 
			{
				get 
				{
					return _Ref;
				}
				set
				{
					_Ref = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Ref
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Document_Task", _Ref);
														}
				set
				{
					base.OnPropertyChanging("Ref");
					_Ref = value.Id;
					base.OnPropertyChanged("Ref");
				}
			}								
			
						
			public static Task_Comment CreateInstance(OfflineContext dao)
            {
                Task_Comment entity = new Task_Comment();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
				//dao.AddItem<Task_Comment>(entity);
                return entity;
            }
		}

		 

		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Task_Problem : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			Task _RefObject;

						
			private Guid _Id;	
			
						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Document_Task_Problem", _Id);
																			}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
									
			private System.Nullable<int> _LineNumber;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<int> LineNumber 
			{
				get 
				{
					return _LineNumber;
				}
				set 
				{
					base.OnPropertyChanging("LineNumber");					
					_LineNumber = value;
					base.OnPropertyChanged("LineNumber");
				}
			}
									
			private String _ProblemDescription;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public String ProblemDescription 
			{
				get 
				{
					return _ProblemDescription;
				}
				set 
				{
					base.OnPropertyChanging("ProblemDescription");					
					_ProblemDescription = value;
					base.OnPropertyChanged("ProblemDescription");
				}
			}
									
			private Guid _Ref;	
			
						public Guid __Ref 
			{
				get 
				{
					return _Ref;
				}
				set
				{
					_Ref = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Ref
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Document_Task", _Ref);
														}
				set
				{
					base.OnPropertyChanging("Ref");
					_Ref = value.Id;
					base.OnPropertyChanged("Ref");
				}
			}								
			
						
			public static Task_Problem CreateInstance(OfflineContext dao)
            {
                Task_Problem entity = new Task_Problem();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
				//dao.AddItem<Task_Problem>(entity);
                return entity;
            }
		}

		 

		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Task_ContactTel : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			Task _RefObject;

						
			private Guid _Id;	
			
						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Document_Task_ContactTel", _Id);
																			}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
									
			private System.Nullable<int> _LineNumber;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<int> LineNumber 
			{
				get 
				{
					return _LineNumber;
				}
				set 
				{
					base.OnPropertyChanging("LineNumber");					
					_LineNumber = value;
					base.OnPropertyChanged("LineNumber");
				}
			}
									
			private String _ContactTel;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public String ContactTel 
			{
				get 
				{
					return _ContactTel;
				}
				set 
				{
					base.OnPropertyChanging("ContactTel");					
					_ContactTel = value;
					base.OnPropertyChanged("ContactTel");
				}
			}
									
			private Guid _Ref;	
			
						public Guid __Ref 
			{
				get 
				{
					return _Ref;
				}
				set
				{
					_Ref = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Ref
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Document_Task", _Ref);
														}
				set
				{
					base.OnPropertyChanging("Ref");
					_Ref = value.Id;
					base.OnPropertyChanged("Ref");
				}
			}								
			
						
			public static Task_ContactTel CreateInstance(OfflineContext dao)
            {
                Task_ContactTel entity = new Task_ContactTel();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
				//dao.AddItem<Task_ContactTel>(entity);
                return entity;
            }
		}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class AVR : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private System.Nullable<bool> _Posted;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Posted 
			{
				get 
				{
					return _Posted;
				}
				set 
				{
					base.OnPropertyChanging("Posted");					
					_Posted = value;
					base.OnPropertyChanged("Posted");
				}
			}
			
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Document_AVR", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private System.Nullable<bool> _DeletionMark;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DeletionMark 
			{
				get 
				{
					return _DeletionMark;
				}
				set 
				{
					base.OnPropertyChanging("DeletionMark");					
					_DeletionMark = value;
					base.OnPropertyChanged("DeletionMark");
				}
			}
			
			
			private DateTime _Date;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public DateTime Date 
			{
				get 
				{
					return _Date;
				}
				set 
				{
					base.OnPropertyChanging("Date");					
					_Date = value;
					base.OnPropertyChanged("Date");
				}
			}
			
			
			private String _Number;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Number 
			{
				get 
				{
					return _Number;
				}
				set 
				{
					base.OnPropertyChanging("Number");					
					_Number = value;
					base.OnPropertyChanged("Number");
				}
			}
			
			
			private Guid _Org;				    

						public Guid __Org 
			{
				get 
				{
					return _Org;
				}
				set
				{
					_Org = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Org
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Org", _Org);
									}
				set
				{
					base.OnPropertyChanging("Org");
					_Org = value.Id;
					base.OnPropertyChanged("Org");
				}
			}								
			
			
			
			private Guid _Counterparty;				    

						public Guid __Counterparty 
			{
				get 
				{
					return _Counterparty;
				}
				set
				{
					_Counterparty = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Counterparty
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Counterparty", _Counterparty);
									}
				set
				{
					base.OnPropertyChanging("Counterparty");
					_Counterparty = value.Id;
					base.OnPropertyChanged("Counterparty");
				}
			}								
			
			
			
			private Guid _Contracts;				    

						public Guid __Contracts 
			{
				get 
				{
					return _Contracts;
				}
				set
				{
					_Contracts = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Contracts
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Contracts", _Contracts);
									}
				set
				{
					base.OnPropertyChanging("Contracts");
					_Contracts = value.Id;
					base.OnPropertyChanged("Contracts");
				}
			}								
			
			
			
			private Guid _Object;				    

						public Guid __Object 
			{
				get 
				{
					return _Object;
				}
				set
				{
					_Object = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Object
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Object", _Object);
									}
				set
				{
					base.OnPropertyChanging("Object");
					_Object = value.Id;
					base.OnPropertyChanged("Object");
				}
			}								
			
			
			
			private Guid _Task;				    

						public Guid __Task 
			{
				get 
				{
					return _Task;
				}
				set
				{
					_Task = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Task
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Document_Task", _Task);
									}
				set
				{
					base.OnPropertyChanging("Task");
					_Task = value.Id;
					base.OnPropertyChanged("Task");
				}
			}								
			
			
			
			private Guid _Department;				    

						public Guid __Department 
			{
				get 
				{
					return _Department;
				}
				set
				{
					_Department = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Department
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Department", _Department);
									}
				set
				{
					base.OnPropertyChanging("Department");
					_Department = value.Id;
					base.OnPropertyChanged("Department");
				}
			}								
			
			
			
			public static AVR CreateInstance(OfflineContext dao)
            {
                AVR entity = new AVR();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<AVR>(entity);
                return entity;
            }

						
			public System.Collections.Generic.IEnumerable<Document.AVR_Jobs> Jobs(OfflineContext context) 
			{
				System.Collections.Generic.List<Document.AVR_Jobs> result = new System.Collections.Generic.List<Document.AVR_Jobs>();
				System.Collections.Generic.IEnumerable<Document.AVR_Jobs> items = context.GetCollection<Document.AVR_Jobs>();
				foreach(var item in items)
				{
					if(item.Ref.Equals(this.Id))
						result.Add(item);
				}
				return result;
			}

						
			public System.Collections.Generic.IEnumerable<Document.AVR_SKU> SKU(OfflineContext context) 
			{
				System.Collections.Generic.List<Document.AVR_SKU> result = new System.Collections.Generic.List<Document.AVR_SKU>();
				System.Collections.Generic.IEnumerable<Document.AVR_SKU> items = context.GetCollection<Document.AVR_SKU>();
				foreach(var item in items)
				{
					if(item.Ref.Equals(this.Id))
						result.Add(item);
				}
				return result;
			}

					}

		 

		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class AVR_Jobs : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			AVR _RefObject;

						
			private Guid _Id;	
			
						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Document_AVR_Jobs", _Id);
																			}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
									
			private System.Nullable<int> _LineNumber;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<int> LineNumber 
			{
				get 
				{
					return _LineNumber;
				}
				set 
				{
					base.OnPropertyChanging("LineNumber");					
					_LineNumber = value;
					base.OnPropertyChanged("LineNumber");
				}
			}
									
			private Guid _Ref;	
			
						public Guid __Ref 
			{
				get 
				{
					return _Ref;
				}
				set
				{
					_Ref = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Ref
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Document_AVR", _Ref);
														}
				set
				{
					base.OnPropertyChanging("Ref");
					_Ref = value.Id;
					base.OnPropertyChanged("Ref");
				}
			}								
			
									
			private Guid _SKU;	
			
						public Guid __SKU 
			{
				get 
				{
					return _SKU;
				}
				set
				{
					_SKU = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef SKU
			{
				get
				{
																				return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_SKU", _SKU);
									}
				set
				{
					base.OnPropertyChanging("SKU");
					_SKU = value.Id;
					base.OnPropertyChanged("SKU");
				}
			}								
			
									
			private System.Nullable<decimal> _JobsCount;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<decimal> JobsCount 
			{
				get 
				{
					return _JobsCount;
				}
				set 
				{
					base.OnPropertyChanging("JobsCount");					
					_JobsCount = value;
					base.OnPropertyChanged("JobsCount");
				}
			}
						
			public static AVR_Jobs CreateInstance(OfflineContext dao)
            {
                AVR_Jobs entity = new AVR_Jobs();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
				//dao.AddItem<AVR_Jobs>(entity);
                return entity;
            }
		}

		 

		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class AVR_SKU : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			AVR _RefObject;

						
			private Guid _Id;	
			
						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Document_AVR_SKU", _Id);
																			}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
									
			private System.Nullable<int> _LineNumber;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<int> LineNumber 
			{
				get 
				{
					return _LineNumber;
				}
				set 
				{
					base.OnPropertyChanging("LineNumber");					
					_LineNumber = value;
					base.OnPropertyChanged("LineNumber");
				}
			}
									
			private Guid _Ref;	
			
						public Guid __Ref 
			{
				get 
				{
					return _Ref;
				}
				set
				{
					_Ref = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Ref
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Document_AVR", _Ref);
														}
				set
				{
					base.OnPropertyChanging("Ref");
					_Ref = value.Id;
					base.OnPropertyChanged("Ref");
				}
			}								
			
									
			private Guid _SKU;	
			
						public Guid __SKU 
			{
				get 
				{
					return _SKU;
				}
				set
				{
					_SKU = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef SKU
			{
				get
				{
																				return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_SKU", _SKU);
									}
				set
				{
					base.OnPropertyChanging("SKU");
					_SKU = value.Id;
					base.OnPropertyChanged("SKU");
				}
			}								
			
									
			private System.Nullable<bool> _DocumentsWritten;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DocumentsWritten 
			{
				get 
				{
					return _DocumentsWritten;
				}
				set 
				{
					base.OnPropertyChanging("DocumentsWritten");					
					_DocumentsWritten = value;
					base.OnPropertyChanged("DocumentsWritten");
				}
			}
									
			private System.Nullable<decimal> _SKUCount;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<decimal> SKUCount 
			{
				get 
				{
					return _SKUCount;
				}
				set 
				{
					base.OnPropertyChanging("SKUCount");					
					_SKUCount = value;
					base.OnPropertyChanged("SKUCount");
				}
			}
						
			public static AVR_SKU CreateInstance(OfflineContext dao)
            {
                AVR_SKU entity = new AVR_SKU();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
				//dao.AddItem<AVR_SKU>(entity);
                return entity;
            }
		}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class bitmobile_AVR : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private System.Nullable<bool> _Posted;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Posted 
			{
				get 
				{
					return _Posted;
				}
				set 
				{
					base.OnPropertyChanging("Posted");					
					_Posted = value;
					base.OnPropertyChanged("Posted");
				}
			}
			
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Document_bitmobile_AVR", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private System.Nullable<bool> _DeletionMark;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DeletionMark 
			{
				get 
				{
					return _DeletionMark;
				}
				set 
				{
					base.OnPropertyChanging("DeletionMark");					
					_DeletionMark = value;
					base.OnPropertyChanged("DeletionMark");
				}
			}
			
			
			private DateTime _Date;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public DateTime Date 
			{
				get 
				{
					return _Date;
				}
				set 
				{
					base.OnPropertyChanging("Date");					
					_Date = value;
					base.OnPropertyChanged("Date");
				}
			}
			
			
			private String _Number;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Number 
			{
				get 
				{
					return _Number;
				}
				set 
				{
					base.OnPropertyChanging("Number");					
					_Number = value;
					base.OnPropertyChanged("Number");
				}
			}
			
			
			private Guid _Task;				    

						public Guid __Task 
			{
				get 
				{
					return _Task;
				}
				set
				{
					_Task = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Task
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Document_Task", _Task);
									}
				set
				{
					base.OnPropertyChanging("Task");
					_Task = value.Id;
					base.OnPropertyChanged("Task");
				}
			}								
			
			
			
			private System.Nullable<bool> _ValueBrigade;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> ValueBrigade 
			{
				get 
				{
					return _ValueBrigade;
				}
				set 
				{
					base.OnPropertyChanging("ValueBrigade");					
					_ValueBrigade = value;
					base.OnPropertyChanged("ValueBrigade");
				}
			}
			
			
			private System.Nullable<decimal> _LatitudeStart;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<decimal> LatitudeStart 
			{
				get 
				{
					return _LatitudeStart;
				}
				set 
				{
					base.OnPropertyChanging("LatitudeStart");					
					_LatitudeStart = value;
					base.OnPropertyChanged("LatitudeStart");
				}
			}
			
			
			private System.Nullable<decimal> _LatitudeFinish;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<decimal> LatitudeFinish 
			{
				get 
				{
					return _LatitudeFinish;
				}
				set 
				{
					base.OnPropertyChanging("LatitudeFinish");					
					_LatitudeFinish = value;
					base.OnPropertyChanged("LatitudeFinish");
				}
			}
			
			
			private System.Nullable<decimal> _LongitudeStart;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<decimal> LongitudeStart 
			{
				get 
				{
					return _LongitudeStart;
				}
				set 
				{
					base.OnPropertyChanging("LongitudeStart");					
					_LongitudeStart = value;
					base.OnPropertyChanged("LongitudeStart");
				}
			}
			
			
			private System.Nullable<decimal> _LongitudeFinish;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<decimal> LongitudeFinish 
			{
				get 
				{
					return _LongitudeFinish;
				}
				set 
				{
					base.OnPropertyChanging("LongitudeFinish");					
					_LongitudeFinish = value;
					base.OnPropertyChanged("LongitudeFinish");
				}
			}
			
			
			public static bitmobile_AVR CreateInstance(OfflineContext dao)
            {
                bitmobile_AVR entity = new bitmobile_AVR();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<bitmobile_AVR>(entity);
                return entity;
            }

						
			public System.Collections.Generic.IEnumerable<Document.bitmobile_AVR_Materials> Materials(OfflineContext context) 
			{
				System.Collections.Generic.List<Document.bitmobile_AVR_Materials> result = new System.Collections.Generic.List<Document.bitmobile_AVR_Materials>();
				System.Collections.Generic.IEnumerable<Document.bitmobile_AVR_Materials> items = context.GetCollection<Document.bitmobile_AVR_Materials>();
				foreach(var item in items)
				{
					if(item.Ref.Equals(this.Id))
						result.Add(item);
				}
				return result;
			}

						
			public System.Collections.Generic.IEnumerable<Document.bitmobile_AVR_Jobs> Jobs(OfflineContext context) 
			{
				System.Collections.Generic.List<Document.bitmobile_AVR_Jobs> result = new System.Collections.Generic.List<Document.bitmobile_AVR_Jobs>();
				System.Collections.Generic.IEnumerable<Document.bitmobile_AVR_Jobs> items = context.GetCollection<Document.bitmobile_AVR_Jobs>();
				foreach(var item in items)
				{
					if(item.Ref.Equals(this.Id))
						result.Add(item);
				}
				return result;
			}

						
			public System.Collections.Generic.IEnumerable<Document.bitmobile_AVR_Photo> Photo(OfflineContext context) 
			{
				System.Collections.Generic.List<Document.bitmobile_AVR_Photo> result = new System.Collections.Generic.List<Document.bitmobile_AVR_Photo>();
				System.Collections.Generic.IEnumerable<Document.bitmobile_AVR_Photo> items = context.GetCollection<Document.bitmobile_AVR_Photo>();
				foreach(var item in items)
				{
					if(item.Ref.Equals(this.Id))
						result.Add(item);
				}
				return result;
			}

					}

		 

		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class bitmobile_AVR_Materials : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			bitmobile_AVR _RefObject;

						
			private Guid _Id;	
			
						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Document_bitmobile_AVR_Materials", _Id);
																			}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
									
			private System.Nullable<int> _LineNumber;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<int> LineNumber 
			{
				get 
				{
					return _LineNumber;
				}
				set 
				{
					base.OnPropertyChanging("LineNumber");					
					_LineNumber = value;
					base.OnPropertyChanged("LineNumber");
				}
			}
									
			private Guid _Ref;	
			
						public Guid __Ref 
			{
				get 
				{
					return _Ref;
				}
				set
				{
					_Ref = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Ref
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Document_bitmobile_AVR", _Ref);
														}
				set
				{
					base.OnPropertyChanging("Ref");
					_Ref = value.Id;
					base.OnPropertyChanged("Ref");
				}
			}								
			
									
			private Guid _SKU;	
			
						public Guid __SKU 
			{
				get 
				{
					return _SKU;
				}
				set
				{
					_SKU = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef SKU
			{
				get
				{
																				return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_SKU", _SKU);
									}
				set
				{
					base.OnPropertyChanging("SKU");
					_SKU = value.Id;
					base.OnPropertyChanged("SKU");
				}
			}								
			
									
			private System.Nullable<decimal> _Count;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<decimal> Count 
			{
				get 
				{
					return _Count;
				}
				set 
				{
					base.OnPropertyChanging("Count");					
					_Count = value;
					base.OnPropertyChanged("Count");
				}
			}
						
			public static bitmobile_AVR_Materials CreateInstance(OfflineContext dao)
            {
                bitmobile_AVR_Materials entity = new bitmobile_AVR_Materials();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
				//dao.AddItem<bitmobile_AVR_Materials>(entity);
                return entity;
            }
		}

		 

		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class bitmobile_AVR_Jobs : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			bitmobile_AVR _RefObject;

						
			private Guid _Id;	
			
						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Document_bitmobile_AVR_Jobs", _Id);
																			}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
									
			private System.Nullable<int> _LineNumber;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<int> LineNumber 
			{
				get 
				{
					return _LineNumber;
				}
				set 
				{
					base.OnPropertyChanging("LineNumber");					
					_LineNumber = value;
					base.OnPropertyChanged("LineNumber");
				}
			}
									
			private Guid _Ref;	
			
						public Guid __Ref 
			{
				get 
				{
					return _Ref;
				}
				set
				{
					_Ref = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Ref
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Document_bitmobile_AVR", _Ref);
														}
				set
				{
					base.OnPropertyChanging("Ref");
					_Ref = value.Id;
					base.OnPropertyChanged("Ref");
				}
			}								
			
									
			private Guid _SKU;	
			
						public Guid __SKU 
			{
				get 
				{
					return _SKU;
				}
				set
				{
					_SKU = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef SKU
			{
				get
				{
																				return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_SKU", _SKU);
									}
				set
				{
					base.OnPropertyChanging("SKU");
					_SKU = value.Id;
					base.OnPropertyChanged("SKU");
				}
			}								
			
									
			private System.Nullable<decimal> _Count;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<decimal> Count 
			{
				get 
				{
					return _Count;
				}
				set 
				{
					base.OnPropertyChanging("Count");					
					_Count = value;
					base.OnPropertyChanged("Count");
				}
			}
						
			public static bitmobile_AVR_Jobs CreateInstance(OfflineContext dao)
            {
                bitmobile_AVR_Jobs entity = new bitmobile_AVR_Jobs();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
				//dao.AddItem<bitmobile_AVR_Jobs>(entity);
                return entity;
            }
		}

		 

		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class bitmobile_AVR_Photo : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			bitmobile_AVR _RefObject;

						
			private Guid _Id;	
			
						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Document_bitmobile_AVR_Photo", _Id);
																			}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
									
			private System.Nullable<int> _LineNumber;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<int> LineNumber 
			{
				get 
				{
					return _LineNumber;
				}
				set 
				{
					base.OnPropertyChanging("LineNumber");					
					_LineNumber = value;
					base.OnPropertyChanged("LineNumber");
				}
			}
									
			private Guid _Ref;	
			
						public Guid __Ref 
			{
				get 
				{
					return _Ref;
				}
				set
				{
					_Ref = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Ref
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Document_bitmobile_AVR", _Ref);
														}
				set
				{
					base.OnPropertyChanging("Ref");
					_Ref = value.Id;
					base.OnPropertyChanged("Ref");
				}
			}								
			
									
			private String _Guid;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Guid 
			{
				get 
				{
					return _Guid;
				}
				set 
				{
					base.OnPropertyChanging("Guid");					
					_Guid = value;
					base.OnPropertyChanged("Guid");
				}
			}
									
			private String _Info;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Info 
			{
				get 
				{
					return _Info;
				}
				set 
				{
					base.OnPropertyChanging("Info");					
					_Info = value;
					base.OnPropertyChanged("Info");
				}
			}
									
			private String _Path;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Path 
			{
				get 
				{
					return _Path;
				}
				set 
				{
					base.OnPropertyChanging("Path");					
					_Path = value;
					base.OnPropertyChanged("Path");
				}
			}
									
			private System.Nullable<DateTime> _Date;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<DateTime> Date 
			{
				get 
				{
					return _Date;
				}
				set 
				{
					base.OnPropertyChanging("Date");					
					_Date = value;
					base.OnPropertyChanged("Date");
				}
			}
						
			public static bitmobile_AVR_Photo CreateInstance(OfflineContext dao)
            {
                bitmobile_AVR_Photo entity = new bitmobile_AVR_Photo();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
				//dao.AddItem<bitmobile_AVR_Photo>(entity);
                return entity;
            }
		}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class InternalOrder : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private System.Nullable<bool> _Posted;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Posted 
			{
				get 
				{
					return _Posted;
				}
				set 
				{
					base.OnPropertyChanging("Posted");					
					_Posted = value;
					base.OnPropertyChanged("Posted");
				}
			}
			
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Document_InternalOrder", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private System.Nullable<bool> _DeletionMark;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DeletionMark 
			{
				get 
				{
					return _DeletionMark;
				}
				set 
				{
					base.OnPropertyChanging("DeletionMark");					
					_DeletionMark = value;
					base.OnPropertyChanged("DeletionMark");
				}
			}
			
			
			private DateTime _Date;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public DateTime Date 
			{
				get 
				{
					return _Date;
				}
				set 
				{
					base.OnPropertyChanging("Date");					
					_Date = value;
					base.OnPropertyChanged("Date");
				}
			}
			
			
			private String _Number;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Number 
			{
				get 
				{
					return _Number;
				}
				set 
				{
					base.OnPropertyChanging("Number");					
					_Number = value;
					base.OnPropertyChanged("Number");
				}
			}
			
			
			private Guid _OrderType;				    

						public Guid __OrderType 
			{
				get 
				{
					return _OrderType;
				}
				set
				{
					_OrderType = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef OrderType
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Enum_OrderType", _OrderType);
									}
				set
				{
					base.OnPropertyChanging("OrderType");
					_OrderType = value.Id;
					base.OnPropertyChanged("OrderType");
				}
			}								
			
			
			
			private System.Nullable<DateTime> _DateShip;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<DateTime> DateShip 
			{
				get 
				{
					return _DateShip;
				}
				set 
				{
					base.OnPropertyChanging("DateShip");					
					_DateShip = value;
					base.OnPropertyChanged("DateShip");
				}
			}
			
			
			private Guid _Org;				    

						public Guid __Org 
			{
				get 
				{
					return _Org;
				}
				set
				{
					_Org = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Org
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Org", _Org);
									}
				set
				{
					base.OnPropertyChanging("Org");
					_Org = value.Id;
					base.OnPropertyChanged("Org");
				}
			}								
			
			
			
			private Guid _Department;				    

						public Guid __Department 
			{
				get 
				{
					return _Department;
				}
				set
				{
					_Department = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Department
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Department", _Department);
									}
				set
				{
					base.OnPropertyChanging("Department");
					_Department = value.Id;
					base.OnPropertyChanged("Department");
				}
			}								
			
			
			
			private Guid _Task;				    

						public Guid __Task 
			{
				get 
				{
					return _Task;
				}
				set
				{
					_Task = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Task
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Document_Task", _Task);
									}
				set
				{
					base.OnPropertyChanging("Task");
					_Task = value.Id;
					base.OnPropertyChanged("Task");
				}
			}								
			
			
			
			private Guid _Sklad;				    

						public Guid __Sklad 
			{
				get 
				{
					return _Sklad;
				}
				set
				{
					_Sklad = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Sklad
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Sklad", _Sklad);
									}
				set
				{
					base.OnPropertyChanging("Sklad");
					_Sklad = value.Id;
					base.OnPropertyChanged("Sklad");
				}
			}								
			
			
			
			private System.Nullable<bool> _UsedInService;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> UsedInService 
			{
				get 
				{
					return _UsedInService;
				}
				set 
				{
					base.OnPropertyChanging("UsedInService");					
					_UsedInService = value;
					base.OnPropertyChanged("UsedInService");
				}
			}
			
			
			public static InternalOrder CreateInstance(OfflineContext dao)
            {
                InternalOrder entity = new InternalOrder();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<InternalOrder>(entity);
                return entity;
            }

						
			public System.Collections.Generic.IEnumerable<Document.InternalOrder_Comment> Comment(OfflineContext context) 
			{
				System.Collections.Generic.List<Document.InternalOrder_Comment> result = new System.Collections.Generic.List<Document.InternalOrder_Comment>();
				System.Collections.Generic.IEnumerable<Document.InternalOrder_Comment> items = context.GetCollection<Document.InternalOrder_Comment>();
				foreach(var item in items)
				{
					if(item.Ref.Equals(this.Id))
						result.Add(item);
				}
				return result;
			}

						
			public System.Collections.Generic.IEnumerable<Document.InternalOrder_StateShipment> StateShipment(OfflineContext context) 
			{
				System.Collections.Generic.List<Document.InternalOrder_StateShipment> result = new System.Collections.Generic.List<Document.InternalOrder_StateShipment>();
				System.Collections.Generic.IEnumerable<Document.InternalOrder_StateShipment> items = context.GetCollection<Document.InternalOrder_StateShipment>();
				foreach(var item in items)
				{
					if(item.Ref.Equals(this.Id))
						result.Add(item);
				}
				return result;
			}

						
			public System.Collections.Generic.IEnumerable<Document.InternalOrder_Goods> Goods(OfflineContext context) 
			{
				System.Collections.Generic.List<Document.InternalOrder_Goods> result = new System.Collections.Generic.List<Document.InternalOrder_Goods>();
				System.Collections.Generic.IEnumerable<Document.InternalOrder_Goods> items = context.GetCollection<Document.InternalOrder_Goods>();
				foreach(var item in items)
				{
					if(item.Ref.Equals(this.Id))
						result.Add(item);
				}
				return result;
			}

						
			public System.Collections.Generic.IEnumerable<Document.InternalOrder_Photo> Photo(OfflineContext context) 
			{
				System.Collections.Generic.List<Document.InternalOrder_Photo> result = new System.Collections.Generic.List<Document.InternalOrder_Photo>();
				System.Collections.Generic.IEnumerable<Document.InternalOrder_Photo> items = context.GetCollection<Document.InternalOrder_Photo>();
				foreach(var item in items)
				{
					if(item.Ref.Equals(this.Id))
						result.Add(item);
				}
				return result;
			}

					}

		 

		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class InternalOrder_Comment : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			InternalOrder _RefObject;

						
			private Guid _Id;	
			
						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Document_InternalOrder_Comment", _Id);
																			}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
									
			private System.Nullable<int> _LineNumber;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<int> LineNumber 
			{
				get 
				{
					return _LineNumber;
				}
				set 
				{
					base.OnPropertyChanging("LineNumber");					
					_LineNumber = value;
					base.OnPropertyChanged("LineNumber");
				}
			}
									
			private String _Comment;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Comment 
			{
				get 
				{
					return _Comment;
				}
				set 
				{
					base.OnPropertyChanging("Comment");					
					_Comment = value;
					base.OnPropertyChanged("Comment");
				}
			}
									
			private Guid _Ref;	
			
						public Guid __Ref 
			{
				get 
				{
					return _Ref;
				}
				set
				{
					_Ref = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Ref
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Document_InternalOrder", _Ref);
														}
				set
				{
					base.OnPropertyChanging("Ref");
					_Ref = value.Id;
					base.OnPropertyChanged("Ref");
				}
			}								
			
						
			public static InternalOrder_Comment CreateInstance(OfflineContext dao)
            {
                InternalOrder_Comment entity = new InternalOrder_Comment();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
				//dao.AddItem<InternalOrder_Comment>(entity);
                return entity;
            }
		}

		 

		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class InternalOrder_StateShipment : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			InternalOrder _RefObject;

						
			private Guid _Id;	
			
						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Document_InternalOrder_StateShipment", _Id);
																			}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
									
			private System.Nullable<int> _LineNumber;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<int> LineNumber 
			{
				get 
				{
					return _LineNumber;
				}
				set 
				{
					base.OnPropertyChanging("LineNumber");					
					_LineNumber = value;
					base.OnPropertyChanged("LineNumber");
				}
			}
									
			private Guid _Ref;	
			
						public Guid __Ref 
			{
				get 
				{
					return _Ref;
				}
				set
				{
					_Ref = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Ref
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Document_InternalOrder", _Ref);
														}
				set
				{
					base.OnPropertyChanging("Ref");
					_Ref = value.Id;
					base.OnPropertyChanged("Ref");
				}
			}								
			
									
			private System.Nullable<decimal> _Count;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<decimal> Count 
			{
				get 
				{
					return _Count;
				}
				set 
				{
					base.OnPropertyChanging("Count");					
					_Count = value;
					base.OnPropertyChanged("Count");
				}
			}
									
			private Guid _SKU;	
			
						public Guid __SKU 
			{
				get 
				{
					return _SKU;
				}
				set
				{
					_SKU = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef SKU
			{
				get
				{
																				return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_SKU", _SKU);
									}
				set
				{
					base.OnPropertyChanging("SKU");
					_SKU = value.Id;
					base.OnPropertyChanged("SKU");
				}
			}								
			
						
			public static InternalOrder_StateShipment CreateInstance(OfflineContext dao)
            {
                InternalOrder_StateShipment entity = new InternalOrder_StateShipment();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
				//dao.AddItem<InternalOrder_StateShipment>(entity);
                return entity;
            }
		}

		 

		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class InternalOrder_Goods : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			InternalOrder _RefObject;

						
			private Guid _Id;	
			
						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Document_InternalOrder_Goods", _Id);
																			}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
									
			private System.Nullable<int> _LineNumber;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<int> LineNumber 
			{
				get 
				{
					return _LineNumber;
				}
				set 
				{
					base.OnPropertyChanging("LineNumber");					
					_LineNumber = value;
					base.OnPropertyChanged("LineNumber");
				}
			}
									
			private Guid _Ref;	
			
						public Guid __Ref 
			{
				get 
				{
					return _Ref;
				}
				set
				{
					_Ref = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Ref
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Document_InternalOrder", _Ref);
														}
				set
				{
					base.OnPropertyChanging("Ref");
					_Ref = value.Id;
					base.OnPropertyChanged("Ref");
				}
			}								
			
									
			private Guid _UnitCat;	
			
						public Guid __UnitCat 
			{
				get 
				{
					return _UnitCat;
				}
				set
				{
					_UnitCat = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef UnitCat
			{
				get
				{
																				return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_UnitCat", _UnitCat);
									}
				set
				{
					base.OnPropertyChanging("UnitCat");
					_UnitCat = value.Id;
					base.OnPropertyChanged("UnitCat");
				}
			}								
			
									
			private System.Nullable<decimal> _Count;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<decimal> Count 
			{
				get 
				{
					return _Count;
				}
				set 
				{
					base.OnPropertyChanging("Count");					
					_Count = value;
					base.OnPropertyChanged("Count");
				}
			}
									
			private System.Nullable<decimal> _Coeff;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<decimal> Coeff 
			{
				get 
				{
					return _Coeff;
				}
				set 
				{
					base.OnPropertyChanging("Coeff");					
					_Coeff = value;
					base.OnPropertyChanged("Coeff");
				}
			}
									
			private Guid _SKU;	
			
						public Guid __SKU 
			{
				get 
				{
					return _SKU;
				}
				set
				{
					_SKU = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef SKU
			{
				get
				{
																				return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_SKU", _SKU);
									}
				set
				{
					base.OnPropertyChanging("SKU");
					_SKU = value.Id;
					base.OnPropertyChanged("SKU");
				}
			}								
			
									
			private Guid _SetsOut;	
			
						public Guid __SetsOut 
			{
				get 
				{
					return _SetsOut;
				}
				set
				{
					_SetsOut = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef SetsOut
			{
				get
				{
																				return BitMobile.DbEngine.DbRef.CreateInstance("Enum_StatusComplect", _SetsOut);
									}
				set
				{
					base.OnPropertyChanging("SetsOut");
					_SetsOut = value.Id;
					base.OnPropertyChanged("SetsOut");
				}
			}								
			
						
			public static InternalOrder_Goods CreateInstance(OfflineContext dao)
            {
                InternalOrder_Goods entity = new InternalOrder_Goods();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
				//dao.AddItem<InternalOrder_Goods>(entity);
                return entity;
            }
		}

		 

		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class InternalOrder_Photo : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			InternalOrder _RefObject;

						
			private Guid _Id;	
			
						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Document_InternalOrder_Photo", _Id);
																			}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
									
			private System.Nullable<int> _LineNumber;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<int> LineNumber 
			{
				get 
				{
					return _LineNumber;
				}
				set 
				{
					base.OnPropertyChanging("LineNumber");					
					_LineNumber = value;
					base.OnPropertyChanged("LineNumber");
				}
			}
									
			private Guid _Ref;	
			
						public Guid __Ref 
			{
				get 
				{
					return _Ref;
				}
				set
				{
					_Ref = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Ref
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Document_InternalOrder", _Ref);
														}
				set
				{
					base.OnPropertyChanging("Ref");
					_Ref = value.Id;
					base.OnPropertyChanged("Ref");
				}
			}								
			
									
			private String _Guid;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Guid 
			{
				get 
				{
					return _Guid;
				}
				set 
				{
					base.OnPropertyChanging("Guid");					
					_Guid = value;
					base.OnPropertyChanged("Guid");
				}
			}
									
			private String _Info;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Info 
			{
				get 
				{
					return _Info;
				}
				set 
				{
					base.OnPropertyChanging("Info");					
					_Info = value;
					base.OnPropertyChanged("Info");
				}
			}
									
			private String _Path;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Path 
			{
				get 
				{
					return _Path;
				}
				set 
				{
					base.OnPropertyChanging("Path");					
					_Path = value;
					base.OnPropertyChanged("Path");
				}
			}
									
			private System.Nullable<DateTime> _Date;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<DateTime> Date 
			{
				get 
				{
					return _Date;
				}
				set 
				{
					base.OnPropertyChanging("Date");					
					_Date = value;
					base.OnPropertyChanged("Date");
				}
			}
						
			public static InternalOrder_Photo CreateInstance(OfflineContext dao)
            {
                InternalOrder_Photo entity = new InternalOrder_Photo();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
				//dao.AddItem<InternalOrder_Photo>(entity);
                return entity;
            }
		}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Moving : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private System.Nullable<bool> _Posted;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Posted 
			{
				get 
				{
					return _Posted;
				}
				set 
				{
					base.OnPropertyChanging("Posted");					
					_Posted = value;
					base.OnPropertyChanged("Posted");
				}
			}
			
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Document_Moving", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private System.Nullable<bool> _DeletionMark;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DeletionMark 
			{
				get 
				{
					return _DeletionMark;
				}
				set 
				{
					base.OnPropertyChanging("DeletionMark");					
					_DeletionMark = value;
					base.OnPropertyChanged("DeletionMark");
				}
			}
			
			
			private DateTime _Date;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public DateTime Date 
			{
				get 
				{
					return _Date;
				}
				set 
				{
					base.OnPropertyChanging("Date");					
					_Date = value;
					base.OnPropertyChanged("Date");
				}
			}
			
			
			private String _Number;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Number 
			{
				get 
				{
					return _Number;
				}
				set 
				{
					base.OnPropertyChanging("Number");					
					_Number = value;
					base.OnPropertyChanged("Number");
				}
			}
			
			
			private Guid _MoveFrom;				    

						public Guid __MoveFrom 
			{
				get 
				{
					return _MoveFrom;
				}
				set
				{
					_MoveFrom = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef MoveFrom
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Sklad", _MoveFrom);
									}
				set
				{
					base.OnPropertyChanging("MoveFrom");
					_MoveFrom = value.Id;
					base.OnPropertyChanged("MoveFrom");
				}
			}								
			
			
			
			private Guid _MoveTo;				    

						public Guid __MoveTo 
			{
				get 
				{
					return _MoveTo;
				}
				set
				{
					_MoveTo = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef MoveTo
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Sklad", _MoveTo);
									}
				set
				{
					base.OnPropertyChanging("MoveTo");
					_MoveTo = value.Id;
					base.OnPropertyChanged("MoveTo");
				}
			}								
			
			
			
			private Guid _Status;				    

						public Guid __Status 
			{
				get 
				{
					return _Status;
				}
				set
				{
					_Status = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Status
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Enum_MovingStatus", _Status);
									}
				set
				{
					base.OnPropertyChanging("Status");
					_Status = value.Id;
					base.OnPropertyChanged("Status");
				}
			}								
			
			
			
			public static Moving CreateInstance(OfflineContext dao)
            {
                Moving entity = new Moving();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<Moving>(entity);
                return entity;
            }

						
			public System.Collections.Generic.IEnumerable<Document.Moving_Goods> Goods(OfflineContext context) 
			{
				System.Collections.Generic.List<Document.Moving_Goods> result = new System.Collections.Generic.List<Document.Moving_Goods>();
				System.Collections.Generic.IEnumerable<Document.Moving_Goods> items = context.GetCollection<Document.Moving_Goods>();
				foreach(var item in items)
				{
					if(item.Ref.Equals(this.Id))
						result.Add(item);
				}
				return result;
			}

					}

		 

		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Moving_Goods : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			Moving _RefObject;

						
			private Guid _Id;	
			
						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Document_Moving_Goods", _Id);
																			}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
									
			private System.Nullable<int> _LineNumber;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<int> LineNumber 
			{
				get 
				{
					return _LineNumber;
				}
				set 
				{
					base.OnPropertyChanging("LineNumber");					
					_LineNumber = value;
					base.OnPropertyChanged("LineNumber");
				}
			}
									
			private Guid _Ref;	
			
						public Guid __Ref 
			{
				get 
				{
					return _Ref;
				}
				set
				{
					_Ref = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Ref
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Document_Moving", _Ref);
														}
				set
				{
					base.OnPropertyChanging("Ref");
					_Ref = value.Id;
					base.OnPropertyChanged("Ref");
				}
			}								
			
									
			private Guid _SKU;	
			
						public Guid __SKU 
			{
				get 
				{
					return _SKU;
				}
				set
				{
					_SKU = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef SKU
			{
				get
				{
																				return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_SKU", _SKU);
									}
				set
				{
					base.OnPropertyChanging("SKU");
					_SKU = value.Id;
					base.OnPropertyChanged("SKU");
				}
			}								
			
									
			private System.Nullable<decimal> _Count;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<decimal> Count 
			{
				get 
				{
					return _Count;
				}
				set 
				{
					base.OnPropertyChanging("Count");					
					_Count = value;
					base.OnPropertyChanged("Count");
				}
			}
						
			public static Moving_Goods CreateInstance(OfflineContext dao)
            {
                Moving_Goods entity = new Moving_Goods();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
				//dao.AddItem<Moving_Goods>(entity);
                return entity;
            }
		}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class News : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private System.Nullable<bool> _Posted;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Posted 
			{
				get 
				{
					return _Posted;
				}
				set 
				{
					base.OnPropertyChanging("Posted");					
					_Posted = value;
					base.OnPropertyChanged("Posted");
				}
			}
			
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Document_News", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private System.Nullable<bool> _DeletionMark;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DeletionMark 
			{
				get 
				{
					return _DeletionMark;
				}
				set 
				{
					base.OnPropertyChanging("DeletionMark");					
					_DeletionMark = value;
					base.OnPropertyChanged("DeletionMark");
				}
			}
			
			
			private DateTime _Date;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public DateTime Date 
			{
				get 
				{
					return _Date;
				}
				set 
				{
					base.OnPropertyChanging("Date");					
					_Date = value;
					base.OnPropertyChanged("Date");
				}
			}
			
			
			private String _Number;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Number 
			{
				get 
				{
					return _Number;
				}
				set 
				{
					base.OnPropertyChanging("Number");					
					_Number = value;
					base.OnPropertyChanged("Number");
				}
			}
			
			
			private String _NewsText;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String NewsText 
			{
				get 
				{
					return _NewsText;
				}
				set 
				{
					base.OnPropertyChanging("NewsText");					
					_NewsText = value;
					base.OnPropertyChanged("NewsText");
				}
			}
			
			
			private Guid _Department;				    

						public Guid __Department 
			{
				get 
				{
					return _Department;
				}
				set
				{
					_Department = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Department
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Department", _Department);
									}
				set
				{
					base.OnPropertyChanging("Department");
					_Department = value.Id;
					base.OnPropertyChanged("Department");
				}
			}								
			
			
			
			public static News CreateInstance(OfflineContext dao)
            {
                News entity = new News();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<News>(entity);
                return entity;
            }

						
			public System.Collections.Generic.IEnumerable<Document.News_Addressee> Addressee(OfflineContext context) 
			{
				System.Collections.Generic.List<Document.News_Addressee> result = new System.Collections.Generic.List<Document.News_Addressee>();
				System.Collections.Generic.IEnumerable<Document.News_Addressee> items = context.GetCollection<Document.News_Addressee>();
				foreach(var item in items)
				{
					if(item.Ref.Equals(this.Id))
						result.Add(item);
				}
				return result;
			}

					}

		 

		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class News_Addressee : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			News _RefObject;

						
			private Guid _Id;	
			
						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Document_News_Addressee", _Id);
																			}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
									
			private System.Nullable<int> _LineNumber;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<int> LineNumber 
			{
				get 
				{
					return _LineNumber;
				}
				set 
				{
					base.OnPropertyChanging("LineNumber");					
					_LineNumber = value;
					base.OnPropertyChanged("LineNumber");
				}
			}
									
			private Guid _Ref;	
			
						public Guid __Ref 
			{
				get 
				{
					return _Ref;
				}
				set
				{
					_Ref = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Ref
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Document_News", _Ref);
														}
				set
				{
					base.OnPropertyChanging("Ref");
					_Ref = value.Id;
					base.OnPropertyChanged("Ref");
				}
			}								
			
									
			private Guid _User;	
			
						public Guid __User 
			{
				get 
				{
					return _User;
				}
				set
				{
					_User = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef User
			{
				get
				{
																				return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_User", _User);
									}
				set
				{
					base.OnPropertyChanging("User");
					_User = value.Id;
					base.OnPropertyChanged("User");
				}
			}								
			
									
			private System.Nullable<bool> _Read;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Read 
			{
				get 
				{
					return _Read;
				}
				set 
				{
					base.OnPropertyChanging("Read");					
					_Read = value;
					base.OnPropertyChanged("Read");
				}
			}
						
			public static News_Addressee CreateInstance(OfflineContext dao)
            {
                News_Addressee entity = new News_Addressee();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
				//dao.AddItem<News_Addressee>(entity);
                return entity;
            }
		}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Plan : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private System.Nullable<bool> _Posted;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> Posted 
			{
				get 
				{
					return _Posted;
				}
				set 
				{
					base.OnPropertyChanging("Posted");					
					_Posted = value;
					base.OnPropertyChanged("Posted");
				}
			}
			
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Document_Plan", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private System.Nullable<bool> _DeletionMark;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<bool> DeletionMark 
			{
				get 
				{
					return _DeletionMark;
				}
				set 
				{
					base.OnPropertyChanging("DeletionMark");					
					_DeletionMark = value;
					base.OnPropertyChanged("DeletionMark");
				}
			}
			
			
			private DateTime _Date;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public DateTime Date 
			{
				get 
				{
					return _Date;
				}
				set 
				{
					base.OnPropertyChanging("Date");					
					_Date = value;
					base.OnPropertyChanged("Date");
				}
			}
			
			
			private String _Number;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Number 
			{
				get 
				{
					return _Number;
				}
				set 
				{
					base.OnPropertyChanging("Number");					
					_Number = value;
					base.OnPropertyChanged("Number");
				}
			}
			
			
			private Guid _Department;				    

						public Guid __Department 
			{
				get 
				{
					return _Department;
				}
				set
				{
					_Department = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Department
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Department", _Department);
									}
				set
				{
					base.OnPropertyChanging("Department");
					_Department = value.Id;
					base.OnPropertyChanged("Department");
				}
			}								
			
			
			
			private System.Nullable<DateTime> _Period;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<DateTime> Period 
			{
				get 
				{
					return _Period;
				}
				set 
				{
					base.OnPropertyChanging("Period");					
					_Period = value;
					base.OnPropertyChanged("Period");
				}
			}
			
			
			private Guid _StatusPlan;				    

						public Guid __StatusPlan 
			{
				get 
				{
					return _StatusPlan;
				}
				set
				{
					_StatusPlan = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef StatusPlan
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Enum_StatusPlan", _StatusPlan);
									}
				set
				{
					base.OnPropertyChanging("StatusPlan");
					_StatusPlan = value.Id;
					base.OnPropertyChanged("StatusPlan");
				}
			}								
			
			
			
			private Guid _Org;				    

						public Guid __Org 
			{
				get 
				{
					return _Org;
				}
				set
				{
					_Org = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Org
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Org", _Org);
									}
				set
				{
					base.OnPropertyChanging("Org");
					_Org = value.Id;
					base.OnPropertyChanged("Org");
				}
			}								
			
			
			
			private Guid _Users;				    

						public Guid __Users 
			{
				get 
				{
					return _Users;
				}
				set
				{
					_Users = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Users
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Users", _Users);
									}
				set
				{
					base.OnPropertyChanging("Users");
					_Users = value.Id;
					base.OnPropertyChanged("Users");
				}
			}								
			
			
			
			public static Plan CreateInstance(OfflineContext dao)
            {
                Plan entity = new Plan();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<Plan>(entity);
                return entity;
            }

						
			public System.Collections.Generic.IEnumerable<Document.Plan_Denial> Denial(OfflineContext context) 
			{
				System.Collections.Generic.List<Document.Plan_Denial> result = new System.Collections.Generic.List<Document.Plan_Denial>();
				System.Collections.Generic.IEnumerable<Document.Plan_Denial> items = context.GetCollection<Document.Plan_Denial>();
				foreach(var item in items)
				{
					if(item.Ref.Equals(this.Id))
						result.Add(item);
				}
				return result;
			}

						
			public System.Collections.Generic.IEnumerable<Document.Plan_ObjectList> ObjectList(OfflineContext context) 
			{
				System.Collections.Generic.List<Document.Plan_ObjectList> result = new System.Collections.Generic.List<Document.Plan_ObjectList>();
				System.Collections.Generic.IEnumerable<Document.Plan_ObjectList> items = context.GetCollection<Document.Plan_ObjectList>();
				foreach(var item in items)
				{
					if(item.Ref.Equals(this.Id))
						result.Add(item);
				}
				return result;
			}

					}

		 

		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Plan_Denial : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			Plan _RefObject;

						
			private Guid _Id;	
			
						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Document_Plan_Denial", _Id);
																			}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
									
			private System.Nullable<int> _LineNumber;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<int> LineNumber 
			{
				get 
				{
					return _LineNumber;
				}
				set 
				{
					base.OnPropertyChanging("LineNumber");					
					_LineNumber = value;
					base.OnPropertyChanged("LineNumber");
				}
			}
									
			private String _DenialReason;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public String DenialReason 
			{
				get 
				{
					return _DenialReason;
				}
				set 
				{
					base.OnPropertyChanging("DenialReason");					
					_DenialReason = value;
					base.OnPropertyChanged("DenialReason");
				}
			}
									
			private Guid _Ref;	
			
						public Guid __Ref 
			{
				get 
				{
					return _Ref;
				}
				set
				{
					_Ref = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Ref
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Document_Plan", _Ref);
														}
				set
				{
					base.OnPropertyChanging("Ref");
					_Ref = value.Id;
					base.OnPropertyChanged("Ref");
				}
			}								
			
						
			public static Plan_Denial CreateInstance(OfflineContext dao)
            {
                Plan_Denial entity = new Plan_Denial();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
				//dao.AddItem<Plan_Denial>(entity);
                return entity;
            }
		}

		 

		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Plan_ObjectList : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			Plan _RefObject;

						
			private Guid _Id;	
			
						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Document_Plan_ObjectList", _Id);
																			}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
									
			private System.Nullable<int> _LineNumber;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<int> LineNumber 
			{
				get 
				{
					return _LineNumber;
				}
				set 
				{
					base.OnPropertyChanging("LineNumber");					
					_LineNumber = value;
					base.OnPropertyChanged("LineNumber");
				}
			}
									
			private Guid _Ref;	
			
						public Guid __Ref 
			{
				get 
				{
					return _Ref;
				}
				set
				{
					_Ref = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Ref
			{
				get
				{
															return BitMobile.DbEngine.DbRef.CreateInstance("Document_Plan", _Ref);
														}
				set
				{
					base.OnPropertyChanging("Ref");
					_Ref = value.Id;
					base.OnPropertyChanged("Ref");
				}
			}								
			
									
			private Guid _Counterparty;	
			
						public Guid __Counterparty 
			{
				get 
				{
					return _Counterparty;
				}
				set
				{
					_Counterparty = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Counterparty
			{
				get
				{
																				return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Counterparty", _Counterparty);
									}
				set
				{
					base.OnPropertyChanging("Counterparty");
					_Counterparty = value.Id;
					base.OnPropertyChanged("Counterparty");
				}
			}								
			
									
			private Guid _Object;	
			
						public Guid __Object 
			{
				get 
				{
					return _Object;
				}
				set
				{
					_Object = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Object
			{
				get
				{
																				return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_Object", _Object);
									}
				set
				{
					base.OnPropertyChanging("Object");
					_Object = value.Id;
					base.OnPropertyChanged("Object");
				}
			}								
			
									
			private Guid _IntervalService;	
			
						public Guid __IntervalService 
			{
				get 
				{
					return _IntervalService;
				}
				set
				{
					_IntervalService = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef IntervalService
			{
				get
				{
																				return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_IntervalService", _IntervalService);
									}
				set
				{
					base.OnPropertyChanging("IntervalService");
					_IntervalService = value.Id;
					base.OnPropertyChanged("IntervalService");
				}
			}								
			
									
			private System.Nullable<DateTime> _DatePlan;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<DateTime> DatePlan 
			{
				get 
				{
					return _DatePlan;
				}
				set 
				{
					base.OnPropertyChanging("DatePlan");					
					_DatePlan = value;
					base.OnPropertyChanged("DatePlan");
				}
			}
									
			private System.Nullable<DateTime> _DateLastService;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public System.Nullable<DateTime> DateLastService 
			{
				get 
				{
					return _DateLastService;
				}
				set 
				{
					base.OnPropertyChanging("DateLastService");					
					_DateLastService = value;
					base.OnPropertyChanged("DateLastService");
				}
			}
									
			private Guid _Task;	
			
						public Guid __Task 
			{
				get 
				{
					return _Task;
				}
				set
				{
					_Task = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Task
			{
				get
				{
																				return BitMobile.DbEngine.DbRef.CreateInstance("Document_Task", _Task);
									}
				set
				{
					base.OnPropertyChanging("Task");
					_Task = value.Id;
					base.OnPropertyChanged("Task");
				}
			}								
			
									
			private Guid _ContactName;	
			
						public Guid __ContactName 
			{
				get 
				{
					return _ContactName;
				}
				set
				{
					_ContactName = value;
				}
			}
			
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef ContactName
			{
				get
				{
																				return BitMobile.DbEngine.DbRef.CreateInstance("Catalog_ContactName", _ContactName);
									}
				set
				{
					base.OnPropertyChanging("ContactName");
					_ContactName = value.Id;
					base.OnPropertyChanged("ContactName");
				}
			}								
			
									
			private String _ContactTel;	
			
			
						[BitMobile.DbEngine.ColumnAttribute]
			public String ContactTel 
			{
				get 
				{
					return _ContactTel;
				}
				set 
				{
					base.OnPropertyChanging("ContactTel");					
					_ContactTel = value;
					base.OnPropertyChanged("ContactTel");
				}
			}
						
			public static Plan_ObjectList CreateInstance(OfflineContext dao)
            {
                Plan_ObjectList entity = new Plan_ObjectList();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
				//dao.AddItem<Plan_ObjectList>(entity);
                return entity;
            }
		}

		        
		
		public class Collections
		{
			private OfflineContext context;

			public Collections(OfflineContext context)
			{
				this.context = context;
			}

			 

			public System.Collections.Generic.IEnumerable<Document.Task> Task 
			{
				get 
				{
					return context.GetCollection<Document.Task>();
				}
			}


			 
			
			public System.Collections.Generic.IEnumerable<Document.Task_Comment> Task_Comment 
			{
				get 
				{
					return context.GetCollection<Document.Task_Comment>();
				}
			}
			
			 
			
			public System.Collections.Generic.IEnumerable<Document.Task_Problem> Task_Problem 
			{
				get 
				{
					return context.GetCollection<Document.Task_Problem>();
				}
			}
			
			 
			
			public System.Collections.Generic.IEnumerable<Document.Task_ContactTel> Task_ContactTel 
			{
				get 
				{
					return context.GetCollection<Document.Task_ContactTel>();
				}
			}
			
			
			 

			public System.Collections.Generic.IEnumerable<Document.AVR> AVR 
			{
				get 
				{
					return context.GetCollection<Document.AVR>();
				}
			}


			 
			
			public System.Collections.Generic.IEnumerable<Document.AVR_Jobs> AVR_Jobs 
			{
				get 
				{
					return context.GetCollection<Document.AVR_Jobs>();
				}
			}
			
			 
			
			public System.Collections.Generic.IEnumerable<Document.AVR_SKU> AVR_SKU 
			{
				get 
				{
					return context.GetCollection<Document.AVR_SKU>();
				}
			}
			
			
			 

			public System.Collections.Generic.IEnumerable<Document.bitmobile_AVR> bitmobile_AVR 
			{
				get 
				{
					return context.GetCollection<Document.bitmobile_AVR>();
				}
			}


			 
			
			public System.Collections.Generic.IEnumerable<Document.bitmobile_AVR_Materials> bitmobile_AVR_Materials 
			{
				get 
				{
					return context.GetCollection<Document.bitmobile_AVR_Materials>();
				}
			}
			
			 
			
			public System.Collections.Generic.IEnumerable<Document.bitmobile_AVR_Jobs> bitmobile_AVR_Jobs 
			{
				get 
				{
					return context.GetCollection<Document.bitmobile_AVR_Jobs>();
				}
			}
			
			 
			
			public System.Collections.Generic.IEnumerable<Document.bitmobile_AVR_Photo> bitmobile_AVR_Photo 
			{
				get 
				{
					return context.GetCollection<Document.bitmobile_AVR_Photo>();
				}
			}
			
			
			 

			public System.Collections.Generic.IEnumerable<Document.InternalOrder> InternalOrder 
			{
				get 
				{
					return context.GetCollection<Document.InternalOrder>();
				}
			}


			 
			
			public System.Collections.Generic.IEnumerable<Document.InternalOrder_Comment> InternalOrder_Comment 
			{
				get 
				{
					return context.GetCollection<Document.InternalOrder_Comment>();
				}
			}
			
			 
			
			public System.Collections.Generic.IEnumerable<Document.InternalOrder_StateShipment> InternalOrder_StateShipment 
			{
				get 
				{
					return context.GetCollection<Document.InternalOrder_StateShipment>();
				}
			}
			
			 
			
			public System.Collections.Generic.IEnumerable<Document.InternalOrder_Goods> InternalOrder_Goods 
			{
				get 
				{
					return context.GetCollection<Document.InternalOrder_Goods>();
				}
			}
			
			 
			
			public System.Collections.Generic.IEnumerable<Document.InternalOrder_Photo> InternalOrder_Photo 
			{
				get 
				{
					return context.GetCollection<Document.InternalOrder_Photo>();
				}
			}
			
			
			 

			public System.Collections.Generic.IEnumerable<Document.Moving> Moving 
			{
				get 
				{
					return context.GetCollection<Document.Moving>();
				}
			}


			 
			
			public System.Collections.Generic.IEnumerable<Document.Moving_Goods> Moving_Goods 
			{
				get 
				{
					return context.GetCollection<Document.Moving_Goods>();
				}
			}
			
			
			 

			public System.Collections.Generic.IEnumerable<Document.News> News 
			{
				get 
				{
					return context.GetCollection<Document.News>();
				}
			}


			 
			
			public System.Collections.Generic.IEnumerable<Document.News_Addressee> News_Addressee 
			{
				get 
				{
					return context.GetCollection<Document.News_Addressee>();
				}
			}
			
			
			 

			public System.Collections.Generic.IEnumerable<Document.Plan> Plan 
			{
				get 
				{
					return context.GetCollection<Document.Plan>();
				}
			}


			 
			
			public System.Collections.Generic.IEnumerable<Document.Plan_Denial> Plan_Denial 
			{
				get 
				{
					return context.GetCollection<Document.Plan_Denial>();
				}
			}
			
			 
			
			public System.Collections.Generic.IEnumerable<Document.Plan_ObjectList> Plan_ObjectList 
			{
				get 
				{
					return context.GetCollection<Document.Plan_ObjectList>();
				}
			}
			
			
					}

	}

	 
	namespace Enum 
	{
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class LocationType : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Enum_LocationType", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private String _Name;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Name 
			{
				get 
				{
					return _Name;
				}
				set 
				{
					base.OnPropertyChanging("Name");					
					_Name = value;
					base.OnPropertyChanged("Name");
				}
			}
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			public static LocationType CreateInstance(OfflineContext dao)
            {
                LocationType entity = new LocationType();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<LocationType>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class MovingStatus : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Enum_MovingStatus", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private String _Name;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Name 
			{
				get 
				{
					return _Name;
				}
				set 
				{
					base.OnPropertyChanging("Name");					
					_Name = value;
					base.OnPropertyChanged("Name");
				}
			}
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			public static MovingStatus CreateInstance(OfflineContext dao)
            {
                MovingStatus entity = new MovingStatus();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<MovingStatus>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class ObjectStatus : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Enum_ObjectStatus", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private String _Name;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Name 
			{
				get 
				{
					return _Name;
				}
				set 
				{
					base.OnPropertyChanging("Name");					
					_Name = value;
					base.OnPropertyChanged("Name");
				}
			}
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			public static ObjectStatus CreateInstance(OfflineContext dao)
            {
                ObjectStatus entity = new ObjectStatus();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<ObjectStatus>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class OrderType : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Enum_OrderType", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private String _Name;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Name 
			{
				get 
				{
					return _Name;
				}
				set 
				{
					base.OnPropertyChanging("Name");					
					_Name = value;
					base.OnPropertyChanged("Name");
				}
			}
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			public static OrderType CreateInstance(OfflineContext dao)
            {
                OrderType entity = new OrderType();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<OrderType>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Periodicity : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Enum_Periodicity", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private String _Name;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Name 
			{
				get 
				{
					return _Name;
				}
				set 
				{
					base.OnPropertyChanging("Name");					
					_Name = value;
					base.OnPropertyChanged("Name");
				}
			}
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			public static Periodicity CreateInstance(OfflineContext dao)
            {
                Periodicity entity = new Periodicity();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<Periodicity>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class StatusComplect : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Enum_StatusComplect", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private String _Name;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Name 
			{
				get 
				{
					return _Name;
				}
				set 
				{
					base.OnPropertyChanging("Name");					
					_Name = value;
					base.OnPropertyChanged("Name");
				}
			}
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			public static StatusComplect CreateInstance(OfflineContext dao)
            {
                StatusComplect entity = new StatusComplect();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<StatusComplect>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class StatusConsignments : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Enum_StatusConsignments", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private String _Name;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Name 
			{
				get 
				{
					return _Name;
				}
				set 
				{
					base.OnPropertyChanging("Name");					
					_Name = value;
					base.OnPropertyChanged("Name");
				}
			}
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			public static StatusConsignments CreateInstance(OfflineContext dao)
            {
                StatusConsignments entity = new StatusConsignments();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<StatusConsignments>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class StatusPlan : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Enum_StatusPlan", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private String _Name;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Name 
			{
				get 
				{
					return _Name;
				}
				set 
				{
					base.OnPropertyChanging("Name");					
					_Name = value;
					base.OnPropertyChanged("Name");
				}
			}
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			public static StatusPlan CreateInstance(OfflineContext dao)
            {
                StatusPlan entity = new StatusPlan();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<StatusPlan>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class StatusTasks : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Enum_StatusTasks", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private String _Name;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Name 
			{
				get 
				{
					return _Name;
				}
				set 
				{
					base.OnPropertyChanging("Name");					
					_Name = value;
					base.OnPropertyChanged("Name");
				}
			}
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			public static StatusTasks CreateInstance(OfflineContext dao)
            {
                StatusTasks entity = new StatusTasks();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<StatusTasks>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class TypeOfContract : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Enum_TypeOfContract", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private String _Name;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Name 
			{
				get 
				{
					return _Name;
				}
				set 
				{
					base.OnPropertyChanging("Name");					
					_Name = value;
					base.OnPropertyChanged("Name");
				}
			}
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			public static TypeOfContract CreateInstance(OfflineContext dao)
            {
                TypeOfContract entity = new TypeOfContract();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<TypeOfContract>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class ViewTasks : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("Enum_ViewTasks", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private String _Name;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Name 
			{
				get 
				{
					return _Name;
				}
				set 
				{
					base.OnPropertyChanging("Name");					
					_Name = value;
					base.OnPropertyChanged("Name");
				}
			}
			
			
			private String _Description;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Description 
			{
				get 
				{
					return _Description;
				}
				set 
				{
					base.OnPropertyChanging("Description");					
					_Description = value;
					base.OnPropertyChanged("Description");
				}
			}
			
			
			public static ViewTasks CreateInstance(OfflineContext dao)
            {
                ViewTasks entity = new ViewTasks();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<ViewTasks>(entity);
                return entity;
            }

					}

		        
		
		public class Collections
		{
			private OfflineContext context;

			public Collections(OfflineContext context)
			{
				this.context = context;
			}

			 

			public System.Collections.Generic.IEnumerable<Enum.LocationType> LocationType 
			{
				get 
				{
					return context.GetCollection<Enum.LocationType>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<Enum.MovingStatus> MovingStatus 
			{
				get 
				{
					return context.GetCollection<Enum.MovingStatus>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<Enum.ObjectStatus> ObjectStatus 
			{
				get 
				{
					return context.GetCollection<Enum.ObjectStatus>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<Enum.OrderType> OrderType 
			{
				get 
				{
					return context.GetCollection<Enum.OrderType>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<Enum.Periodicity> Periodicity 
			{
				get 
				{
					return context.GetCollection<Enum.Periodicity>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<Enum.StatusComplect> StatusComplect 
			{
				get 
				{
					return context.GetCollection<Enum.StatusComplect>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<Enum.StatusConsignments> StatusConsignments 
			{
				get 
				{
					return context.GetCollection<Enum.StatusConsignments>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<Enum.StatusPlan> StatusPlan 
			{
				get 
				{
					return context.GetCollection<Enum.StatusPlan>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<Enum.StatusTasks> StatusTasks 
			{
				get 
				{
					return context.GetCollection<Enum.StatusTasks>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<Enum.TypeOfContract> TypeOfContract 
			{
				get 
				{
					return context.GetCollection<Enum.TypeOfContract>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<Enum.ViewTasks> ViewTasks 
			{
				get 
				{
					return context.GetCollection<Enum.ViewTasks>();
				}
			}


			
					}

	}

	 
	namespace resource 
	{
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class BusinessProcess : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("resource_BusinessProcess", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private String _Name;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Name 
			{
				get 
				{
					return _Name;
				}
				set 
				{
					base.OnPropertyChanging("Name");					
					_Name = value;
					base.OnPropertyChanged("Name");
				}
			}
			
			
			private String _Data;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Data 
			{
				get 
				{
					return _Data;
				}
				set 
				{
					base.OnPropertyChanging("Data");					
					_Data = value;
					base.OnPropertyChanged("Data");
				}
			}
			
			
			private String _Parent;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Parent 
			{
				get 
				{
					return _Parent;
				}
				set 
				{
					base.OnPropertyChanging("Parent");					
					_Parent = value;
					base.OnPropertyChanged("Parent");
				}
			}
			
			
			public static BusinessProcess CreateInstance(OfflineContext dao)
            {
                BusinessProcess entity = new BusinessProcess();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<BusinessProcess>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Configuration : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("resource_Configuration", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private String _Name;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Name 
			{
				get 
				{
					return _Name;
				}
				set 
				{
					base.OnPropertyChanging("Name");					
					_Name = value;
					base.OnPropertyChanged("Name");
				}
			}
			
			
			private String _Data;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Data 
			{
				get 
				{
					return _Data;
				}
				set 
				{
					base.OnPropertyChanging("Data");					
					_Data = value;
					base.OnPropertyChanged("Data");
				}
			}
			
			
			private String _Parent;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Parent 
			{
				get 
				{
					return _Parent;
				}
				set 
				{
					base.OnPropertyChanging("Parent");					
					_Parent = value;
					base.OnPropertyChanged("Parent");
				}
			}
			
			
			public static Configuration CreateInstance(OfflineContext dao)
            {
                Configuration entity = new Configuration();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<Configuration>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Image : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("resource_Image", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private String _Name;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Name 
			{
				get 
				{
					return _Name;
				}
				set 
				{
					base.OnPropertyChanging("Name");					
					_Name = value;
					base.OnPropertyChanged("Name");
				}
			}
			
			
			private String _Data;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Data 
			{
				get 
				{
					return _Data;
				}
				set 
				{
					base.OnPropertyChanging("Data");					
					_Data = value;
					base.OnPropertyChanged("Data");
				}
			}
			
			
			private String _Parent;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Parent 
			{
				get 
				{
					return _Parent;
				}
				set 
				{
					base.OnPropertyChanging("Parent");					
					_Parent = value;
					base.OnPropertyChanged("Parent");
				}
			}
			
			
			public static Image CreateInstance(OfflineContext dao)
            {
                Image entity = new Image();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<Image>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Screen : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("resource_Screen", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private String _Name;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Name 
			{
				get 
				{
					return _Name;
				}
				set 
				{
					base.OnPropertyChanging("Name");					
					_Name = value;
					base.OnPropertyChanged("Name");
				}
			}
			
			
			private String _Data;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Data 
			{
				get 
				{
					return _Data;
				}
				set 
				{
					base.OnPropertyChanging("Data");					
					_Data = value;
					base.OnPropertyChanged("Data");
				}
			}
			
			
			private String _Parent;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Parent 
			{
				get 
				{
					return _Parent;
				}
				set 
				{
					base.OnPropertyChanging("Parent");					
					_Parent = value;
					base.OnPropertyChanged("Parent");
				}
			}
			
			
			public static Screen CreateInstance(OfflineContext dao)
            {
                Screen entity = new Screen();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<Screen>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Script : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("resource_Script", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private String _Name;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Name 
			{
				get 
				{
					return _Name;
				}
				set 
				{
					base.OnPropertyChanging("Name");					
					_Name = value;
					base.OnPropertyChanged("Name");
				}
			}
			
			
			private String _Data;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Data 
			{
				get 
				{
					return _Data;
				}
				set 
				{
					base.OnPropertyChanging("Data");					
					_Data = value;
					base.OnPropertyChanged("Data");
				}
			}
			
			
			private String _Parent;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Parent 
			{
				get 
				{
					return _Parent;
				}
				set 
				{
					base.OnPropertyChanging("Parent");					
					_Parent = value;
					base.OnPropertyChanged("Parent");
				}
			}
			
			
			public static Script CreateInstance(OfflineContext dao)
            {
                Script entity = new Script();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<Script>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Style : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("resource_Style", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private String _Name;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Name 
			{
				get 
				{
					return _Name;
				}
				set 
				{
					base.OnPropertyChanging("Name");					
					_Name = value;
					base.OnPropertyChanged("Name");
				}
			}
			
			
			private String _Data;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Data 
			{
				get 
				{
					return _Data;
				}
				set 
				{
					base.OnPropertyChanging("Data");					
					_Data = value;
					base.OnPropertyChanged("Data");
				}
			}
			
			
			private String _Parent;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Parent 
			{
				get 
				{
					return _Parent;
				}
				set 
				{
					base.OnPropertyChanging("Parent");					
					_Parent = value;
					base.OnPropertyChanged("Parent");
				}
			}
			
			
			public static Style CreateInstance(OfflineContext dao)
            {
                Style entity = new Style();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<Style>(entity);
                return entity;
            }

					}

		        
		 
		
		[System.Serializable]
		[BitMobile.DbEngine.TableAttribute]
		public partial class Translation : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			
			private Guid _Id;				    

						public Guid __Id 
			{
				get 
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			
						[System.ComponentModel.DataAnnotations.KeyAttribute()]
			[BitMobile.DbEngine.PrimaryKeyAttribute]
						[BitMobile.DbEngine.ColumnAttribute]
			public BitMobile.DbEngine.DbRef Id
			{
				get
				{
										return BitMobile.DbEngine.DbRef.CreateInstance("resource_Translation", _Id);
														}
				set
				{
					base.OnPropertyChanging("Id");
					_Id = value.Id;
					base.OnPropertyChanged("Id");
				}
			}								
			
			
			
			private String _Name;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Name 
			{
				get 
				{
					return _Name;
				}
				set 
				{
					base.OnPropertyChanging("Name");					
					_Name = value;
					base.OnPropertyChanged("Name");
				}
			}
			
			
			private String _Data;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Data 
			{
				get 
				{
					return _Data;
				}
				set 
				{
					base.OnPropertyChanging("Data");					
					_Data = value;
					base.OnPropertyChanged("Data");
				}
			}
			
			
			private String _Parent;				    

			
						[BitMobile.DbEngine.ColumnAttribute]
			public String Parent 
			{
				get 
				{
					return _Parent;
				}
				set 
				{
					base.OnPropertyChanging("Parent");					
					_Parent = value;
					base.OnPropertyChanged("Parent");
				}
			}
			
			
			public static Translation CreateInstance(OfflineContext dao)
            {
                Translation entity = new Translation();
				//entity.Init();
                entity._Id = System.Guid.NewGuid();
				entity.SetIsNew();
                //dao.AddItem<Translation>(entity);
                return entity;
            }

					}

		        
		
		public class Collections
		{
			private OfflineContext context;

			public Collections(OfflineContext context)
			{
				this.context = context;
			}

			 

			public System.Collections.Generic.IEnumerable<resource.BusinessProcess> BusinessProcess 
			{
				get 
				{
					return context.GetCollection<resource.BusinessProcess>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<resource.Configuration> Configuration 
			{
				get 
				{
					return context.GetCollection<resource.Configuration>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<resource.Image> Image 
			{
				get 
				{
					return context.GetCollection<resource.Image>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<resource.Screen> Screen 
			{
				get 
				{
					return context.GetCollection<resource.Screen>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<resource.Script> Script 
			{
				get 
				{
					return context.GetCollection<resource.Script>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<resource.Style> Style 
			{
				get 
				{
					return context.GetCollection<resource.Style>();
				}
			}


			
			 

			public System.Collections.Generic.IEnumerable<resource.Translation> Translation 
			{
				get 
				{
					return context.GetCollection<resource.Translation>();
				}
			}


			
					}

	}

	
	public partial class OfflineContext : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineContext 
	{    
        public const string SyncScopeName = "DefaultScope";
        
        public OfflineContext(string cachePath, System.Uri serviceUri) : 
                base(OfflineContext.GetSchema(), SyncScopeName, cachePath, serviceUri) {
        }
        
        public OfflineContext(string cachePath, System.Uri serviceUri, System.Security.Cryptography.SymmetricAlgorithm symmAlgorithm) : 
                base(OfflineContext.GetSchema(), SyncScopeName, cachePath, serviceUri, symmAlgorithm) {
        }

		 
		
		private admin.Collections _admin;
		public admin.Collections admin
        {
            get
            {
                if (_admin == null)
                    _admin = new admin.Collections(this);
                return _admin;
            }
        }

		 
		
		private Catalog.Collections _Catalog;
		public Catalog.Collections Catalog
        {
            get
            {
                if (_Catalog == null)
                    _Catalog = new Catalog.Collections(this);
                return _Catalog;
            }
        }

		 
		
		private Document.Collections _Document;
		public Document.Collections Document
        {
            get
            {
                if (_Document == null)
                    _Document = new Document.Collections(this);
                return _Document;
            }
        }

		 
		
		private Enum.Collections _Enum;
		public Enum.Collections Enum
        {
            get
            {
                if (_Enum == null)
                    _Enum = new Enum.Collections(this);
                return _Enum;
            }
        }

		 
		
		private resource.Collections _resource;
		public resource.Collections resource
        {
            get
            {
                if (_resource == null)
                    _resource = new resource.Collections(this);
                return _resource;
            }
        }

		


        private static Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageSchema GetSchema() 
		{
            Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageSchema schema = new Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageSchema();
			            schema.AddCollection<admin.Entity>();

			
			            schema.AddCollection<Catalog.Counterparty>();

			
			            schema.AddCollection<Catalog.ContactName>();

			
			            schema.AddCollection<Catalog.ContactPosition>();

			
			            schema.AddCollection<Catalog.TypesOfSettlement>();

			
			            schema.AddCollection<Catalog.TypeOfWork>();

			
			            schema.AddCollection<Catalog.Org>();

			
			            schema.AddCollection<Catalog.Users>();

			
			            schema.AddCollection<Catalog.ObjectContactName>();

			
			            schema.AddCollection<Catalog.GroupObjects>();

			
			            schema.AddCollection<Catalog.DutyRegions>();

			
			            schema.AddCollection<Catalog.Object>();

			 
            schema.AddCollection<Catalog.Object_Comment>();
			 
            schema.AddCollection<Catalog.Object_Equipment>();
			 
            schema.AddCollection<Catalog.Object_Features>();
			
			            schema.AddCollection<Catalog.Contracts>();

			
			            schema.AddCollection<Catalog.Department>();

			
			            schema.AddCollection<Catalog.IntervalService>();

			 
            schema.AddCollection<Catalog.IntervalService_Comment>();
			
			            schema.AddCollection<Catalog.Unit>();

			
			            schema.AddCollection<Catalog.SKU>();

			 
            schema.AddCollection<Catalog.SKU_Stocks>();
			 
            schema.AddCollection<Catalog.SKU_Limits>();
			
			            schema.AddCollection<Catalog.SerialNumber>();

			
			            schema.AddCollection<Catalog.Person>();

			
			            schema.AddCollection<Catalog.Sklad>();

			 
            schema.AddCollection<Catalog.Sklad_Department>();
			
			            schema.AddCollection<Catalog.TypesService>();

			
			            schema.AddCollection<Catalog.UnitCat>();

			
			            schema.AddCollection<Catalog.User>();

			
			            schema.AddCollection<Document.Task>();

			 
            schema.AddCollection<Document.Task_Comment>();
			 
            schema.AddCollection<Document.Task_Problem>();
			 
            schema.AddCollection<Document.Task_ContactTel>();
			
			            schema.AddCollection<Document.AVR>();

			 
            schema.AddCollection<Document.AVR_Jobs>();
			 
            schema.AddCollection<Document.AVR_SKU>();
			
			            schema.AddCollection<Document.bitmobile_AVR>();

			 
            schema.AddCollection<Document.bitmobile_AVR_Materials>();
			 
            schema.AddCollection<Document.bitmobile_AVR_Jobs>();
			 
            schema.AddCollection<Document.bitmobile_AVR_Photo>();
			
			            schema.AddCollection<Document.InternalOrder>();

			 
            schema.AddCollection<Document.InternalOrder_Comment>();
			 
            schema.AddCollection<Document.InternalOrder_StateShipment>();
			 
            schema.AddCollection<Document.InternalOrder_Goods>();
			 
            schema.AddCollection<Document.InternalOrder_Photo>();
			
			            schema.AddCollection<Document.Moving>();

			 
            schema.AddCollection<Document.Moving_Goods>();
			
			            schema.AddCollection<Document.News>();

			 
            schema.AddCollection<Document.News_Addressee>();
			
			            schema.AddCollection<Document.Plan>();

			 
            schema.AddCollection<Document.Plan_Denial>();
			 
            schema.AddCollection<Document.Plan_ObjectList>();
			
			            schema.AddCollection<Enum.LocationType>();

			
			            schema.AddCollection<Enum.MovingStatus>();

			
			            schema.AddCollection<Enum.ObjectStatus>();

			
			            schema.AddCollection<Enum.OrderType>();

			
			            schema.AddCollection<Enum.Periodicity>();

			
			            schema.AddCollection<Enum.StatusComplect>();

			
			            schema.AddCollection<Enum.StatusConsignments>();

			
			            schema.AddCollection<Enum.StatusPlan>();

			
			            schema.AddCollection<Enum.StatusTasks>();

			
			            schema.AddCollection<Enum.TypeOfContract>();

			
			            schema.AddCollection<Enum.ViewTasks>();

			
			            schema.AddCollection<resource.BusinessProcess>();

			
			            schema.AddCollection<resource.Configuration>();

			
			            schema.AddCollection<resource.Image>();

			
			            schema.AddCollection<resource.Screen>();

			
			            schema.AddCollection<resource.Script>();

			
			            schema.AddCollection<resource.Style>();

			
			            schema.AddCollection<resource.Translation>();

			
			            return schema;
        }
    }

}
