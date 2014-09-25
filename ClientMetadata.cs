using System;

namespace DefaultScope 
{
	public class Metadata
	{
		private String type;
		private String name;

		public Metadata(String Type, String Name)
		{
			this.type = Type;
			this.name = Name;
		}

		public String Type
		{
			get
			{
				return type;
			}
		}

		public String Name
		{
			get
			{
				return name;
			}
		}

	}


	 
	namespace admin 
	{
		 

		public partial class Entity : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static EntityMetadata metadata;

			public static EntityMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static Entity()
			{
				metadata = new EntityMetadata();
			}
		}


		public class EntityMetadata
		{
			
			
			
			
			
			
			
			
			
			public EntityMetadata()
			{

			
			
			
			
			
			
			
			
			
			}
		}
        
			}

	 
	namespace Catalog 
	{
		 

		public partial class Counterparty : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static CounterpartyMetadata metadata;

			public static CounterpartyMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static Counterparty()
			{
				metadata = new CounterpartyMetadata();
			}
		}


		public class CounterpartyMetadata
		{
			
			
			
			
			
			
			
			
			
			
			
			
			
			public CounterpartyMetadata()
			{

			
			
			
			
			
			
			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class ContactName : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static ContactNameMetadata metadata;

			public static ContactNameMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static ContactName()
			{
				metadata = new ContactNameMetadata();
			}
		}


		public class ContactNameMetadata
		{
			
			
			
			
			
			
			
			
			private Metadata _Owner;
			public Metadata Owner
			{
				get
				{
					return _Owner;
				}
			}
			 
			
			
			
			
			
			
			
			
			public ContactNameMetadata()
			{

			
			
			
			
			
			
			
			
				_Owner = new Metadata("Catalog","Counterparty");
			 
			
			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class ContactPosition : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static ContactPositionMetadata metadata;

			public static ContactPositionMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static ContactPosition()
			{
				metadata = new ContactPositionMetadata();
			}
		}


		public class ContactPositionMetadata
		{
			
			
			
			
			
			
			
			
			
			
			
			public ContactPositionMetadata()
			{

			
			
			
			
			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class TypesOfSettlement : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static TypesOfSettlementMetadata metadata;

			public static TypesOfSettlementMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static TypesOfSettlement()
			{
				metadata = new TypesOfSettlementMetadata();
			}
		}


		public class TypesOfSettlementMetadata
		{
			
			
			
			
			
			
			
			
			
			
			
			public TypesOfSettlementMetadata()
			{

			
			
			
			
			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class TypeOfWork : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static TypeOfWorkMetadata metadata;

			public static TypeOfWorkMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static TypeOfWork()
			{
				metadata = new TypeOfWorkMetadata();
			}
		}


		public class TypeOfWorkMetadata
		{
			
			
			
			
			
			
			
			
			
			
			
			public TypeOfWorkMetadata()
			{

			
			
			
			
			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class Org : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static OrgMetadata metadata;

			public static OrgMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static Org()
			{
				metadata = new OrgMetadata();
			}
		}


		public class OrgMetadata
		{
			
			
			
			
			
			
			
			
			
			
			
			public OrgMetadata()
			{

			
			
			
			
			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class Users : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static UsersMetadata metadata;

			public static UsersMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static Users()
			{
				metadata = new UsersMetadata();
			}
		}


		public class UsersMetadata
		{
			
			
			
			
			
			
			
			
			
			
			private Metadata _Parent;
			public Metadata Parent
			{
				get
				{
					return _Parent;
				}
			}
			 
			
			
			
			
			
			
			public UsersMetadata()
			{

			
			
			
			
			
			
			
			
			
			
				_Parent = new Metadata("Catalog","Users");
			 
			
			
			
			
			
			
			}
		}
        
		 

		public partial class ObjectContactName : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static ObjectContactNameMetadata metadata;

			public static ObjectContactNameMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static ObjectContactName()
			{
				metadata = new ObjectContactNameMetadata();
			}
		}


		public class ObjectContactNameMetadata
		{
			
			
			
			
			
			
			
			
			
			
			
			
			
			public ObjectContactNameMetadata()
			{

			
			
			
			
			
			
			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class GroupObjects : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static GroupObjectsMetadata metadata;

			public static GroupObjectsMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static GroupObjects()
			{
				metadata = new GroupObjectsMetadata();
			}
		}


		public class GroupObjectsMetadata
		{
			
			
			
			
			
			
			
			
			
			
			
			public GroupObjectsMetadata()
			{

			
			
			
			
			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class DutyRegions : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static DutyRegionsMetadata metadata;

			public static DutyRegionsMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static DutyRegions()
			{
				metadata = new DutyRegionsMetadata();
			}
		}


		public class DutyRegionsMetadata
		{
			
			
			
			
			
			
			
			
			
			
			
			public DutyRegionsMetadata()
			{

			
			
			
			
			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class Object : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static ObjectMetadata metadata;

			public static ObjectMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static Object()
			{
				metadata = new ObjectMetadata();
			}
		}


		public class ObjectMetadata
		{
			
			
			
			
			
			
			
			
			private Metadata _Owner;
			public Metadata Owner
			{
				get
				{
					return _Owner;
				}
			}
			 
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			private Metadata _ObjectContactName;
			public Metadata ObjectContactName
			{
				get
				{
					return _ObjectContactName;
				}
			}
			 
			
			
			
			
			
			private Metadata _ContactPosition;
			public Metadata ContactPosition
			{
				get
				{
					return _ContactPosition;
				}
			}
			 
			
			
			
			private Metadata _DutyRegions;
			public Metadata DutyRegions
			{
				get
				{
					return _DutyRegions;
				}
			}
			 
			
			
			
			private Metadata _GroupObjects;
			public Metadata GroupObjects
			{
				get
				{
					return _GroupObjects;
				}
			}
			 
			
			
			
			private Metadata _Users;
			public Metadata Users
			{
				get
				{
					return _Users;
				}
			}
			 
			
			
			
			
			public ObjectMetadata()
			{

			
			
			
			
			
			
			
			
				_Owner = new Metadata("Catalog","Counterparty");
			 
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
				_ObjectContactName = new Metadata("Catalog","ObjectContactName");
			 
			
			
			
			
			
				_ContactPosition = new Metadata("Catalog","ContactPosition");
			 
			
			
			
				_DutyRegions = new Metadata("Catalog","DutyRegions");
			 
			
			
			
				_GroupObjects = new Metadata("Catalog","GroupObjects");
			 
			
			
			
				_Users = new Metadata("Catalog","Users");
			 
			
			
			
			
			}
		}
        
		 

		public partial class Contracts : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static ContractsMetadata metadata;

			public static ContractsMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static Contracts()
			{
				metadata = new ContractsMetadata();
			}
		}


		public class ContractsMetadata
		{
			
			
			
			
			
			
			
			
			
			
			private Metadata _Owner;
			public Metadata Owner
			{
				get
				{
					return _Owner;
				}
			}
			 
			
			
			
			
			
			
			
			private Metadata _TypesOfSettlement;
			public Metadata TypesOfSettlement
			{
				get
				{
					return _TypesOfSettlement;
				}
			}
			 
			
			
			
			private Metadata _Org;
			public Metadata Org
			{
				get
				{
					return _Org;
				}
			}
			 
			
			
			
			
			
			
			
			private Metadata _Object;
			public Metadata Object
			{
				get
				{
					return _Object;
				}
			}
			 
			
			
			
			private Metadata _TypeOfContract;
			public Metadata TypeOfContract
			{
				get
				{
					return _TypeOfContract;
				}
			}
			 
			
			
			
			private Metadata _TypeOfWork;
			public Metadata TypeOfWork
			{
				get
				{
					return _TypeOfWork;
				}
			}
			 
			
			
			public ContractsMetadata()
			{

			
			
			
			
			
			
			
			
			
			
				_Owner = new Metadata("Catalog","Counterparty");
			 
			
			
			
			
			
			
			
				_TypesOfSettlement = new Metadata("Catalog","TypesOfSettlement");
			 
			
			
			
				_Org = new Metadata("Catalog","Org");
			 
			
			
			
			
			
			
			
				_Object = new Metadata("Catalog","Object");
			 
			
			
			
				_TypeOfContract = new Metadata("Enum","TypeOfContract");
			 
			
			
			
				_TypeOfWork = new Metadata("Catalog","TypeOfWork");
			 
			
			
			}
		}
        
		 

		public partial class Department : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static DepartmentMetadata metadata;

			public static DepartmentMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static Department()
			{
				metadata = new DepartmentMetadata();
			}
		}


		public class DepartmentMetadata
		{
			
			
			
			
			
			
			
			
			
			
			
			public DepartmentMetadata()
			{

			
			
			
			
			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class IntervalService : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static IntervalServiceMetadata metadata;

			public static IntervalServiceMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static IntervalService()
			{
				metadata = new IntervalServiceMetadata();
			}
		}


		public class IntervalServiceMetadata
		{
			
			
			
			
			
			
			
			
			
			
			
			
			private Metadata _ObjectStatus;
			public Metadata ObjectStatus
			{
				get
				{
					return _ObjectStatus;
				}
			}
			 
			
			
			
			
			
			private Metadata _Periodicity;
			public Metadata Periodicity
			{
				get
				{
					return _Periodicity;
				}
			}
			 
			
			
			
			
			
			
			public IntervalServiceMetadata()
			{

			
			
			
			
			
			
			
			
			
			
			
			
				_ObjectStatus = new Metadata("Enum","ObjectStatus");
			 
			
			
			
			
			
				_Periodicity = new Metadata("Enum","Periodicity");
			 
			
			
			
			
			
			
			}
		}
        
		 

		public partial class Unit : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static UnitMetadata metadata;

			public static UnitMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static Unit()
			{
				metadata = new UnitMetadata();
			}
		}


		public class UnitMetadata
		{
			
			
			
			
			
			
			
			
			
			
			
			public UnitMetadata()
			{

			
			
			
			
			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class SKU : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static SKUMetadata metadata;

			public static SKUMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static SKU()
			{
				metadata = new SKUMetadata();
			}
		}


		public class SKUMetadata
		{
			
			
			
			
			
			
			
			
			
			
			private Metadata _Parent;
			public Metadata Parent
			{
				get
				{
					return _Parent;
				}
			}
			 
			
			
			
			
			
			
			
			private Metadata _Unit;
			public Metadata Unit
			{
				get
				{
					return _Unit;
				}
			}
			 
			
			
			
			
			
			
			public SKUMetadata()
			{

			
			
			
			
			
			
			
			
			
			
				_Parent = new Metadata("Catalog","SKU");
			 
			
			
			
			
			
			
			
				_Unit = new Metadata("Catalog","Unit");
			 
			
			
			
			
			
			
			}
		}
        
		 

		public partial class SerialNumber : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static SerialNumberMetadata metadata;

			public static SerialNumberMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static SerialNumber()
			{
				metadata = new SerialNumberMetadata();
			}
		}


		public class SerialNumberMetadata
		{
			
			
			
			
			
			
			
			
			private Metadata _Owner;
			public Metadata Owner
			{
				get
				{
					return _Owner;
				}
			}
			 
			
			
			
			
			public SerialNumberMetadata()
			{

			
			
			
			
			
			
			
			
				_Owner = new Metadata("Catalog","SKU");
			 
			
			
			
			
			}
		}
        
		 

		public partial class Person : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static PersonMetadata metadata;

			public static PersonMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static Person()
			{
				metadata = new PersonMetadata();
			}
		}


		public class PersonMetadata
		{
			
			
			
			
			
			
			
			
			
			
			private Metadata _Parent;
			public Metadata Parent
			{
				get
				{
					return _Parent;
				}
			}
			 
			
			
			
			
			
			
			
			private Metadata _ObjectContactName;
			public Metadata ObjectContactName
			{
				get
				{
					return _ObjectContactName;
				}
			}
			 
			
			
			
			private Metadata _Org;
			public Metadata Org
			{
				get
				{
					return _Org;
				}
			}
			 
			
			
			
			private Metadata _Department;
			public Metadata Department
			{
				get
				{
					return _Department;
				}
			}
			 
			
			
			
			private Metadata _ContactPosition;
			public Metadata ContactPosition
			{
				get
				{
					return _ContactPosition;
				}
			}
			 
			
			
			public PersonMetadata()
			{

			
			
			
			
			
			
			
			
			
			
				_Parent = new Metadata("Catalog","Person");
			 
			
			
			
			
			
			
			
				_ObjectContactName = new Metadata("Catalog","ObjectContactName");
			 
			
			
			
				_Org = new Metadata("Catalog","Org");
			 
			
			
			
				_Department = new Metadata("Catalog","Department");
			 
			
			
			
				_ContactPosition = new Metadata("Catalog","ContactPosition");
			 
			
			
			}
		}
        
		 

		public partial class Sklad : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static SkladMetadata metadata;

			public static SkladMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static Sklad()
			{
				metadata = new SkladMetadata();
			}
		}


		public class SkladMetadata
		{
			
			
			
			
			
			
			
			
			
			
			
			
			
			public SkladMetadata()
			{

			
			
			
			
			
			
			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class TypesService : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static TypesServiceMetadata metadata;

			public static TypesServiceMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static TypesService()
			{
				metadata = new TypesServiceMetadata();
			}
		}


		public class TypesServiceMetadata
		{
			
			
			
			
			
			
			
			
			
			
			
			public TypesServiceMetadata()
			{

			
			
			
			
			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class UnitCat : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static UnitCatMetadata metadata;

			public static UnitCatMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static UnitCat()
			{
				metadata = new UnitCatMetadata();
			}
		}


		public class UnitCatMetadata
		{
			
			
			
			
			
			
			
			
			
			
			
			public UnitCatMetadata()
			{

			
			
			
			
			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class User : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static UserMetadata metadata;

			public static UserMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static User()
			{
				metadata = new UserMetadata();
			}
		}


		public class UserMetadata
		{
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			private Metadata _Department;
			public Metadata Department
			{
				get
				{
					return _Department;
				}
			}
			 
			
			
			public UserMetadata()
			{

			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
				_Department = new Metadata("Catalog","Department");
			 
			
			
			}
		}
        
			}

	 
	namespace Document 
	{
		 

		public partial class Task : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static TaskMetadata metadata;

			public static TaskMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static Task()
			{
				metadata = new TaskMetadata();
			}
		}


		public class TaskMetadata
		{
			
			
			
			
			
			
			
			
			
			
			
			
			private Metadata _Org;
			public Metadata Org
			{
				get
				{
					return _Org;
				}
			}
			 
			
			
			
			private Metadata _Counterparty;
			public Metadata Counterparty
			{
				get
				{
					return _Counterparty;
				}
			}
			 
			
			
			
			private Metadata _Object;
			public Metadata Object
			{
				get
				{
					return _Object;
				}
			}
			 
			
			
			
			
			
			
			
			
			
			
			
			
			
			private Metadata _Users;
			public Metadata Users
			{
				get
				{
					return _Users;
				}
			}
			 
			
			
			
			private Metadata _Department;
			public Metadata Department
			{
				get
				{
					return _Department;
				}
			}
			 
			
			
			
			private Metadata _ContactName;
			public Metadata ContactName
			{
				get
				{
					return _ContactName;
				}
			}
			 
			
			
			
			private Metadata _StatusTasks;
			public Metadata StatusTasks
			{
				get
				{
					return _StatusTasks;
				}
			}
			 
			
			
			
			private Metadata _ViewTasks;
			public Metadata ViewTasks
			{
				get
				{
					return _ViewTasks;
				}
			}
			 
			
			
			
			private Metadata _TypesService;
			public Metadata TypesService
			{
				get
				{
					return _TypesService;
				}
			}
			 
			
			
			public TaskMetadata()
			{

			
			
			
			
			
			
			
			
			
			
			
			
				_Org = new Metadata("Catalog","Org");
			 
			
			
			
				_Counterparty = new Metadata("Catalog","Counterparty");
			 
			
			
			
				_Object = new Metadata("Catalog","Object");
			 
			
			
			
			
			
			
			
			
			
			
			
			
			
				_Users = new Metadata("Catalog","Users");
			 
			
			
			
				_Department = new Metadata("Catalog","Department");
			 
			
			
			
				_ContactName = new Metadata("Catalog","ContactName");
			 
			
			
			
				_StatusTasks = new Metadata("Enum","StatusTasks");
			 
			
			
			
				_ViewTasks = new Metadata("Enum","ViewTasks");
			 
			
			
			
				_TypesService = new Metadata("Catalog","TypesService");
			 
			
			
			}
		}
        
		 

		public partial class AVR : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static AVRMetadata metadata;

			public static AVRMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static AVR()
			{
				metadata = new AVRMetadata();
			}
		}


		public class AVRMetadata
		{
			
			
			
			
			
			
			
			
			
			
			
			
			private Metadata _Org;
			public Metadata Org
			{
				get
				{
					return _Org;
				}
			}
			 
			
			
			
			private Metadata _Counterparty;
			public Metadata Counterparty
			{
				get
				{
					return _Counterparty;
				}
			}
			 
			
			
			
			private Metadata _Contracts;
			public Metadata Contracts
			{
				get
				{
					return _Contracts;
				}
			}
			 
			
			
			
			private Metadata _Object;
			public Metadata Object
			{
				get
				{
					return _Object;
				}
			}
			 
			
			
			
			private Metadata _Task;
			public Metadata Task
			{
				get
				{
					return _Task;
				}
			}
			 
			
			
			
			private Metadata _Department;
			public Metadata Department
			{
				get
				{
					return _Department;
				}
			}
			 
			
			
			public AVRMetadata()
			{

			
			
			
			
			
			
			
			
			
			
			
			
				_Org = new Metadata("Catalog","Org");
			 
			
			
			
				_Counterparty = new Metadata("Catalog","Counterparty");
			 
			
			
			
				_Contracts = new Metadata("Catalog","Contracts");
			 
			
			
			
				_Object = new Metadata("Catalog","Object");
			 
			
			
			
				_Task = new Metadata("Document","Task");
			 
			
			
			
				_Department = new Metadata("Catalog","Department");
			 
			
			
			}
		}
        
		 

		public partial class bitmobile_AVR : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static bitmobile_AVRMetadata metadata;

			public static bitmobile_AVRMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static bitmobile_AVR()
			{
				metadata = new bitmobile_AVRMetadata();
			}
		}


		public class bitmobile_AVRMetadata
		{
			
			
			
			
			
			
			
			
			
			
			
			
			private Metadata _Task;
			public Metadata Task
			{
				get
				{
					return _Task;
				}
			}
			 
			
			
			
			
			
			
			
			
			
			
			
			
			public bitmobile_AVRMetadata()
			{

			
			
			
			
			
			
			
			
			
			
			
			
				_Task = new Metadata("Document","Task");
			 
			
			
			
			
			
			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class InternalOrder : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static InternalOrderMetadata metadata;

			public static InternalOrderMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static InternalOrder()
			{
				metadata = new InternalOrderMetadata();
			}
		}


		public class InternalOrderMetadata
		{
			
			
			
			
			
			
			
			
			
			
			
			
			private Metadata _OrderType;
			public Metadata OrderType
			{
				get
				{
					return _OrderType;
				}
			}
			 
			
			
			
			
			
			private Metadata _Org;
			public Metadata Org
			{
				get
				{
					return _Org;
				}
			}
			 
			
			
			
			private Metadata _Department;
			public Metadata Department
			{
				get
				{
					return _Department;
				}
			}
			 
			
			
			
			private Metadata _Task;
			public Metadata Task
			{
				get
				{
					return _Task;
				}
			}
			 
			
			
			
			private Metadata _Sklad;
			public Metadata Sklad
			{
				get
				{
					return _Sklad;
				}
			}
			 
			
			
			
			
			public InternalOrderMetadata()
			{

			
			
			
			
			
			
			
			
			
			
			
			
				_OrderType = new Metadata("Enum","OrderType");
			 
			
			
			
			
			
				_Org = new Metadata("Catalog","Org");
			 
			
			
			
				_Department = new Metadata("Catalog","Department");
			 
			
			
			
				_Task = new Metadata("Document","Task");
			 
			
			
			
				_Sklad = new Metadata("Catalog","Sklad");
			 
			
			
			
			
			}
		}
        
		 

		public partial class Moving : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static MovingMetadata metadata;

			public static MovingMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static Moving()
			{
				metadata = new MovingMetadata();
			}
		}


		public class MovingMetadata
		{
			
			
			
			
			
			
			
			
			
			
			
			
			private Metadata _MoveFrom;
			public Metadata MoveFrom
			{
				get
				{
					return _MoveFrom;
				}
			}
			 
			
			
			
			private Metadata _MoveTo;
			public Metadata MoveTo
			{
				get
				{
					return _MoveTo;
				}
			}
			 
			
			
			
			private Metadata _Status;
			public Metadata Status
			{
				get
				{
					return _Status;
				}
			}
			 
			
			
			public MovingMetadata()
			{

			
			
			
			
			
			
			
			
			
			
			
			
				_MoveFrom = new Metadata("Catalog","Sklad");
			 
			
			
			
				_MoveTo = new Metadata("Catalog","Sklad");
			 
			
			
			
				_Status = new Metadata("Enum","MovingStatus");
			 
			
			
			}
		}
        
		 

		public partial class News : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static NewsMetadata metadata;

			public static NewsMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static News()
			{
				metadata = new NewsMetadata();
			}
		}


		public class NewsMetadata
		{
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			private Metadata _Department;
			public Metadata Department
			{
				get
				{
					return _Department;
				}
			}
			 
			
			
			public NewsMetadata()
			{

			
			
			
			
			
			
			
			
			
			
			
			
			
			
				_Department = new Metadata("Catalog","Department");
			 
			
			
			}
		}
        
		 

		public partial class Plan : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static PlanMetadata metadata;

			public static PlanMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static Plan()
			{
				metadata = new PlanMetadata();
			}
		}


		public class PlanMetadata
		{
			
			
			
			
			
			
			
			
			
			
			
			
			private Metadata _Department;
			public Metadata Department
			{
				get
				{
					return _Department;
				}
			}
			 
			
			
			
			
			
			private Metadata _StatusPlan;
			public Metadata StatusPlan
			{
				get
				{
					return _StatusPlan;
				}
			}
			 
			
			
			
			private Metadata _Org;
			public Metadata Org
			{
				get
				{
					return _Org;
				}
			}
			 
			
			
			
			private Metadata _Users;
			public Metadata Users
			{
				get
				{
					return _Users;
				}
			}
			 
			
			
			public PlanMetadata()
			{

			
			
			
			
			
			
			
			
			
			
			
			
				_Department = new Metadata("Catalog","Department");
			 
			
			
			
			
			
				_StatusPlan = new Metadata("Enum","StatusPlan");
			 
			
			
			
				_Org = new Metadata("Catalog","Org");
			 
			
			
			
				_Users = new Metadata("Catalog","Users");
			 
			
			
			}
		}
        
			}

	 
	namespace Enum 
	{
		 

		public partial class LocationType : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static LocationTypeMetadata metadata;

			public static LocationTypeMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static LocationType()
			{
				metadata = new LocationTypeMetadata();
			}
		}


		public class LocationTypeMetadata
		{
			
			
			
			
			
			
			
			public LocationTypeMetadata()
			{

			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class MovingStatus : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static MovingStatusMetadata metadata;

			public static MovingStatusMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static MovingStatus()
			{
				metadata = new MovingStatusMetadata();
			}
		}


		public class MovingStatusMetadata
		{
			
			
			
			
			
			
			
			public MovingStatusMetadata()
			{

			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class ObjectStatus : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static ObjectStatusMetadata metadata;

			public static ObjectStatusMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static ObjectStatus()
			{
				metadata = new ObjectStatusMetadata();
			}
		}


		public class ObjectStatusMetadata
		{
			
			
			
			
			
			
			
			public ObjectStatusMetadata()
			{

			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class OrderType : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static OrderTypeMetadata metadata;

			public static OrderTypeMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static OrderType()
			{
				metadata = new OrderTypeMetadata();
			}
		}


		public class OrderTypeMetadata
		{
			
			
			
			
			
			
			
			public OrderTypeMetadata()
			{

			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class Periodicity : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static PeriodicityMetadata metadata;

			public static PeriodicityMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static Periodicity()
			{
				metadata = new PeriodicityMetadata();
			}
		}


		public class PeriodicityMetadata
		{
			
			
			
			
			
			
			
			public PeriodicityMetadata()
			{

			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class StatusComplect : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static StatusComplectMetadata metadata;

			public static StatusComplectMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static StatusComplect()
			{
				metadata = new StatusComplectMetadata();
			}
		}


		public class StatusComplectMetadata
		{
			
			
			
			
			
			
			
			public StatusComplectMetadata()
			{

			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class StatusConsignments : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static StatusConsignmentsMetadata metadata;

			public static StatusConsignmentsMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static StatusConsignments()
			{
				metadata = new StatusConsignmentsMetadata();
			}
		}


		public class StatusConsignmentsMetadata
		{
			
			
			
			
			
			
			
			public StatusConsignmentsMetadata()
			{

			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class StatusPlan : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static StatusPlanMetadata metadata;

			public static StatusPlanMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static StatusPlan()
			{
				metadata = new StatusPlanMetadata();
			}
		}


		public class StatusPlanMetadata
		{
			
			
			
			
			
			
			
			public StatusPlanMetadata()
			{

			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class StatusTasks : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static StatusTasksMetadata metadata;

			public static StatusTasksMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static StatusTasks()
			{
				metadata = new StatusTasksMetadata();
			}
		}


		public class StatusTasksMetadata
		{
			
			
			
			
			
			
			
			public StatusTasksMetadata()
			{

			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class TypeOfContract : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static TypeOfContractMetadata metadata;

			public static TypeOfContractMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static TypeOfContract()
			{
				metadata = new TypeOfContractMetadata();
			}
		}


		public class TypeOfContractMetadata
		{
			
			
			
			
			
			
			
			public TypeOfContractMetadata()
			{

			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class ViewTasks : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static ViewTasksMetadata metadata;

			public static ViewTasksMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static ViewTasks()
			{
				metadata = new ViewTasksMetadata();
			}
		}


		public class ViewTasksMetadata
		{
			
			
			
			
			
			
			
			public ViewTasksMetadata()
			{

			
			
			
			
			
			
			
			}
		}
        
			}

	 
	namespace resource 
	{
		 

		public partial class BusinessProcess : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static BusinessProcessMetadata metadata;

			public static BusinessProcessMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static BusinessProcess()
			{
				metadata = new BusinessProcessMetadata();
			}
		}


		public class BusinessProcessMetadata
		{
			
			
			
			
			
			
			
			
			
			public BusinessProcessMetadata()
			{

			
			
			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class Configuration : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static ConfigurationMetadata metadata;

			public static ConfigurationMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static Configuration()
			{
				metadata = new ConfigurationMetadata();
			}
		}


		public class ConfigurationMetadata
		{
			
			
			
			
			
			
			
			
			
			public ConfigurationMetadata()
			{

			
			
			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class Image : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static ImageMetadata metadata;

			public static ImageMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static Image()
			{
				metadata = new ImageMetadata();
			}
		}


		public class ImageMetadata
		{
			
			
			
			
			
			
			
			
			
			public ImageMetadata()
			{

			
			
			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class Screen : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static ScreenMetadata metadata;

			public static ScreenMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static Screen()
			{
				metadata = new ScreenMetadata();
			}
		}


		public class ScreenMetadata
		{
			
			
			
			
			
			
			
			
			
			public ScreenMetadata()
			{

			
			
			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class Script : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static ScriptMetadata metadata;

			public static ScriptMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static Script()
			{
				metadata = new ScriptMetadata();
			}
		}


		public class ScriptMetadata
		{
			
			
			
			
			
			
			
			
			
			public ScriptMetadata()
			{

			
			
			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class Style : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static StyleMetadata metadata;

			public static StyleMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static Style()
			{
				metadata = new StyleMetadata();
			}
		}


		public class StyleMetadata
		{
			
			
			
			
			
			
			
			
			
			public StyleMetadata()
			{

			
			
			
			
			
			
			
			
			
			}
		}
        
		 

		public partial class Translation : Microsoft.Synchronization.ClientServices.IsolatedStorage.IsolatedStorageOfflineEntity 
		{
			private static TranslationMetadata metadata;

			public static TranslationMetadata Metadata
			{
				get
				{
					return metadata;
				}
			}

			static Translation()
			{
				metadata = new TranslationMetadata();
			}
		}


		public class TranslationMetadata
		{
			
			
			
			
			
			
			
			
			
			public TranslationMetadata()
			{

			
			
			
			
			
			
			
			
			
			}
		}
        
			}

	
}
