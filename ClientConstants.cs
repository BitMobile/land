using System;

namespace DefaultScope
{
	namespace Constants
	{
		public class Constants
		{
			 
			private LocationType _LocationType;
			public LocationType LocationType
			{
				get
				{
					return _LocationType;
				}
			}
			 
			private TypeOfContract _TypeOfContract;
			public TypeOfContract TypeOfContract
			{
				get
				{
					return _TypeOfContract;
				}
			}
			 
			private ObjectStatus _ObjectStatus;
			public ObjectStatus ObjectStatus
			{
				get
				{
					return _ObjectStatus;
				}
			}
			 
			private Periodicity _Periodicity;
			public Periodicity Periodicity
			{
				get
				{
					return _Periodicity;
				}
			}
			 
			private StatusPlan _StatusPlan;
			public StatusPlan StatusPlan
			{
				get
				{
					return _StatusPlan;
				}
			}
			 
			private StatusComplect _StatusComplect;
			public StatusComplect StatusComplect
			{
				get
				{
					return _StatusComplect;
				}
			}
			 
			private OrderType _OrderType;
			public OrderType OrderType
			{
				get
				{
					return _OrderType;
				}
			}
			 
			private StatusConsignments _StatusConsignments;
			public StatusConsignments StatusConsignments
			{
				get
				{
					return _StatusConsignments;
				}
			}
			 
			private StatusTasks _StatusTasks;
			public StatusTasks StatusTasks
			{
				get
				{
					return _StatusTasks;
				}
			}
			 
			private ViewTasks _ViewTasks;
			public ViewTasks ViewTasks
			{
				get
				{
					return _ViewTasks;
				}
			}
			 
			private MovingStatus _MovingStatus;
			public MovingStatus MovingStatus
			{
				get
				{
					return _MovingStatus;
				}
			}
			
			public Constants()
			{
				 
				_LocationType = new LocationType();
				 
				_TypeOfContract = new TypeOfContract();
				 
				_ObjectStatus = new ObjectStatus();
				 
				_Periodicity = new Periodicity();
				 
				_StatusPlan = new StatusPlan();
				 
				_StatusComplect = new StatusComplect();
				 
				_OrderType = new OrderType();
				 
				_StatusConsignments = new StatusConsignments();
				 
				_StatusTasks = new StatusTasks();
				 
				_ViewTasks = new ViewTasks();
				 
				_MovingStatus = new MovingStatus();
							}
		}

		 
		public class LocationType
		{
					
			public BitMobile.DbEngine.DbRef НаМестеКонтрагент
			{
				get
				{
					//return new Guid("861c56f3-b96f-4655-46ee-c08573ac72b8");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_LocationType", new Guid("861c56f3-b96f-4655-46ee-c08573ac72b8"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef НаМестеПодразделение
			{
				get
				{
					//return new Guid("a8b1f2dc-9518-0211-48f5-9f058e1a272f");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_LocationType", new Guid("a8b1f2dc-9518-0211-48f5-9f058e1a272f"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef ВПутиКонтрагентПодразделение
			{
				get
				{
					//return new Guid("b4a27065-9bf0-33c8-4b6a-82b21e01b4d0");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_LocationType", new Guid("b4a27065-9bf0-33c8-4b6a-82b21e01b4d0"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef ВПутиПодразделениеПодразделение
			{
				get
				{
					//return new Guid("be97d412-0ce7-abdc-49ff-9ca4f1ca12b4");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_LocationType", new Guid("be97d412-0ce7-abdc-49ff-9ca4f1ca12b4"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef ВПутиПодразделениеКонтрагент
			{
				get
				{
					//return new Guid("a9220f30-b688-dc47-41ad-9c0f4a7dd8d3");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_LocationType", new Guid("a9220f30-b688-dc47-41ad-9c0f4a7dd8d3"));
				}
			}		 
					} 
		 
		public class TypeOfContract
		{
					
			public BitMobile.DbEngine.DbRef Договор
			{
				get
				{
					//return new Guid("98f51f92-71ec-b04b-4270-de9887982280");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_TypeOfContract", new Guid("98f51f92-71ec-b04b-4270-de9887982280"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef Спецификация
			{
				get
				{
					//return new Guid("b506b890-4dc3-115a-48fe-5f14fc22809d");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_TypeOfContract", new Guid("b506b890-4dc3-115a-48fe-5f14fc22809d"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef ДоговорСчет
			{
				get
				{
					//return new Guid("aa421def-bed0-6d1c-4777-ac7b5434c209");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_TypeOfContract", new Guid("aa421def-bed0-6d1c-4777-ac7b5434c209"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef ДопСоглашение
			{
				get
				{
					//return new Guid("a5c12f2b-c010-c9a7-4c1c-9dc4e82094b0");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_TypeOfContract", new Guid("a5c12f2b-c010-c9a7-4c1c-9dc4e82094b0"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef ЗаказНаПоставку
			{
				get
				{
					//return new Guid("b063a1cd-e338-867f-4095-0be5ed3fba06");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_TypeOfContract", new Guid("b063a1cd-e338-867f-4095-0be5ed3fba06"));
				}
			}		 
					} 
		 
		public class ObjectStatus
		{
					
			public BitMobile.DbEngine.DbRef Подготовлен
			{
				get
				{
					//return new Guid("b08e1d09-4cb0-923b-4105-d8619d3093c1");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_ObjectStatus", new Guid("b08e1d09-4cb0-923b-4105-d8619d3093c1"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef Согласован
			{
				get
				{
					//return new Guid("894cbc1c-4621-3535-43af-fc24736c8ee7");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_ObjectStatus", new Guid("894cbc1c-4621-3535-43af-fc24736c8ee7"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef ВизаДиректора
			{
				get
				{
					//return new Guid("8af759e4-f4f3-00f1-4e7d-2b6fb8307c5f");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_ObjectStatus", new Guid("8af759e4-f4f3-00f1-4e7d-2b6fb8307c5f"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef Проверен
			{
				get
				{
					//return new Guid("acc4f1a2-93a2-bcc5-480d-1925f5ba492b");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_ObjectStatus", new Guid("acc4f1a2-93a2-bcc5-480d-1925f5ba492b"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef Воплату
			{
				get
				{
					//return new Guid("afec3d34-842a-51af-4eb9-f9a0613c7c83");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_ObjectStatus", new Guid("afec3d34-842a-51af-4eb9-f9a0613c7c83"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef Размещен
			{
				get
				{
					//return new Guid("8fb200be-ea32-f405-4262-0b7de8fff268");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_ObjectStatus", new Guid("8fb200be-ea32-f405-4262-0b7de8fff268"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef Утвержден
			{
				get
				{
					//return new Guid("a907633c-5050-52d6-4a06-e8608f2e04c6");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_ObjectStatus", new Guid("a907633c-5050-52d6-4a06-e8608f2e04c6"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef Отложен
			{
				get
				{
					//return new Guid("b6dd3fc8-3efe-0326-4059-4bafc0316856");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_ObjectStatus", new Guid("b6dd3fc8-3efe-0326-4059-4bafc0316856"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef Отклонен
			{
				get
				{
					//return new Guid("8b8d4932-5c63-86f1-4fa0-3d7cedf3b172");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_ObjectStatus", new Guid("8b8d4932-5c63-86f1-4fa0-3d7cedf3b172"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef Закрыт
			{
				get
				{
					//return new Guid("a9afcbba-6a33-a724-4e9b-cf82d09bd9f5");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_ObjectStatus", new Guid("a9afcbba-6a33-a724-4e9b-cf82d09bd9f5"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef ВПодготовке
			{
				get
				{
					//return new Guid("851fc9f2-f179-5680-4a72-8a6529dc29ee");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_ObjectStatus", new Guid("851fc9f2-f179-5680-4a72-8a6529dc29ee"));
				}
			}		 
					} 
		 
		public class Periodicity
		{
					
			public BitMobile.DbEngine.DbRef День
			{
				get
				{
					//return new Guid("a77cf8a9-2a53-a0cc-460b-2a2a45bfa26a");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_Periodicity", new Guid("a77cf8a9-2a53-a0cc-460b-2a2a45bfa26a"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef Неделя
			{
				get
				{
					//return new Guid("b1971392-1b7f-93c3-4163-9eb3448e2ef1");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_Periodicity", new Guid("b1971392-1b7f-93c3-4163-9eb3448e2ef1"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef Месяц
			{
				get
				{
					//return new Guid("aea4d4c0-1943-5931-4add-5854c56db50d");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_Periodicity", new Guid("aea4d4c0-1943-5931-4add-5854c56db50d"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef Квартал
			{
				get
				{
					//return new Guid("a53f4685-4677-5598-4e8d-e262f2f7135d");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_Periodicity", new Guid("a53f4685-4677-5598-4e8d-e262f2f7135d"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef Год
			{
				get
				{
					//return new Guid("a7e062bd-c8e0-2f1c-4c7e-9b44e4ee6590");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_Periodicity", new Guid("a7e062bd-c8e0-2f1c-4c7e-9b44e4ee6590"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef Декада
			{
				get
				{
					//return new Guid("8c420f55-9572-2072-4e75-a2f48c4e1b6b");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_Periodicity", new Guid("8c420f55-9572-2072-4e75-a2f48c4e1b6b"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef Полугодие
			{
				get
				{
					//return new Guid("8edefe55-2ffc-8ad1-4f02-a3674f31faac");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_Periodicity", new Guid("8edefe55-2ffc-8ad1-4f02-a3674f31faac"));
				}
			}		 
					} 
		 
		public class StatusPlan
		{
					
			public BitMobile.DbEngine.DbRef Редактируется
			{
				get
				{
					//return new Guid("898eba88-3e6e-79d5-48fb-88252f7fe890");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_StatusPlan", new Guid("898eba88-3e6e-79d5-48fb-88252f7fe890"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef НаРассмотрении
			{
				get
				{
					//return new Guid("b5aaffd3-ad90-ff6f-4236-3124cd966caf");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_StatusPlan", new Guid("b5aaffd3-ad90-ff6f-4236-3124cd966caf"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef Утвержден
			{
				get
				{
					//return new Guid("bff8024a-6460-34a4-4752-6a6d1975c8d7");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_StatusPlan", new Guid("bff8024a-6460-34a4-4752-6a6d1975c8d7"));
				}
			}		 
					} 
		 
		public class StatusComplect
		{
					
			public BitMobile.DbEngine.DbRef Основное
			{
				get
				{
					//return new Guid("8237adbb-2c51-fbdd-443c-54187b9a347a");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_StatusComplect", new Guid("8237adbb-2c51-fbdd-443c-54187b9a347a"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef Аксессуар
			{
				get
				{
					//return new Guid("9e9e796f-bac9-2670-48fc-8ac8d48079b2");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_StatusComplect", new Guid("9e9e796f-bac9-2670-48fc-8ac8d48079b2"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef ВнеКомплекта
			{
				get
				{
					//return new Guid("978ed8cd-0ecb-638a-4426-ecbe79188b92");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_StatusComplect", new Guid("978ed8cd-0ecb-638a-4426-ecbe79188b92"));
				}
			}		 
					} 
		 
		public class OrderType
		{
					
			public BitMobile.DbEngine.DbRef НаСклад
			{
				get
				{
					//return new Guid("9d4bd398-3d7b-acb5-4327-b1a74ae21c5b");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_OrderType", new Guid("9d4bd398-3d7b-acb5-4327-b1a74ae21c5b"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef ВПодразделение
			{
				get
				{
					//return new Guid("817c373c-3c6e-d425-4a42-c45869d5e9a5");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_OrderType", new Guid("817c373c-3c6e-d425-4a42-c45869d5e9a5"));
				}
			}		 
					} 
		 
		public class StatusConsignments
		{
					
			public BitMobile.DbEngine.DbRef ВозвратнаяТара
			{
				get
				{
					//return new Guid("b6866a8d-b6bc-0dfe-49af-acc737e0fff0");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_StatusConsignments", new Guid("b6866a8d-b6bc-0dfe-49af-acc737e0fff0"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef ВПереработку
			{
				get
				{
					//return new Guid("a442075a-00b9-75b8-4429-65610fe0dcfc");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_StatusConsignments", new Guid("a442075a-00b9-75b8-4429-65610fe0dcfc"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef Купленный
			{
				get
				{
					//return new Guid("a7ea9837-38b5-0459-493b-5d56de47876a");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_StatusConsignments", new Guid("a7ea9837-38b5-0459-493b-5d56de47876a"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef НаКомиссию
			{
				get
				{
					//return new Guid("8f5d1cf7-3124-4ba3-4e92-0a7391397751");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_StatusConsignments", new Guid("8f5d1cf7-3124-4ba3-4e92-0a7391397751"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef Оборудование
			{
				get
				{
					//return new Guid("a38dfa8b-032c-672b-4c96-4c8179f42a2f");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_StatusConsignments", new Guid("a38dfa8b-032c-672b-4c96-4c8179f42a2f"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef ПоОрдеру
			{
				get
				{
					//return new Guid("9cb60656-aec9-ec8a-4a11-a71d683ebeae");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_StatusConsignments", new Guid("9cb60656-aec9-ec8a-4a11-a71d683ebeae"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef Продукция
			{
				get
				{
					//return new Guid("b7c0c73b-b4ea-2b93-440d-77c5ea612c78");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_StatusConsignments", new Guid("b7c0c73b-b4ea-2b93-440d-77c5ea612c78"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef ВозвратнаяТараОтложеннаяОтгрузка
			{
				get
				{
					//return new Guid("9843c4b1-2776-8fee-4eed-8ef7125b4cf6");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_StatusConsignments", new Guid("9843c4b1-2776-8fee-4eed-8ef7125b4cf6"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef КупленныйОтложеннаяОтгрузка
			{
				get
				{
					//return new Guid("bac86a37-7769-8927-4299-b868e2e3e49f");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_StatusConsignments", new Guid("bac86a37-7769-8927-4299-b868e2e3e49f"));
				}
			}		 
					} 
		 
		public class StatusTasks
		{
					
			public BitMobile.DbEngine.DbRef Новая
			{
				get
				{
					//return new Guid("b92d0bb1-9062-74ef-428d-7384740ad3c2");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_StatusTasks", new Guid("b92d0bb1-9062-74ef-428d-7384740ad3c2"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef ВРаботе
			{
				get
				{
					//return new Guid("867cc4e2-98af-3371-467d-ee879cd0d665");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_StatusTasks", new Guid("867cc4e2-98af-3371-467d-ee879cd0d665"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef Отменена
			{
				get
				{
					//return new Guid("983204d6-92aa-e0fd-4315-258242877c2f");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_StatusTasks", new Guid("983204d6-92aa-e0fd-4315-258242877c2f"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef Закрыта
			{
				get
				{
					//return new Guid("b9b59f80-b32f-d50d-49b2-a933459dbe91");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_StatusTasks", new Guid("b9b59f80-b32f-d50d-49b2-a933459dbe91"));
				}
			}		 
					} 
		 
		public class ViewTasks
		{
					
			public BitMobile.DbEngine.DbRef ВнеплановыеРаботы
			{
				get
				{
					//return new Guid("bcd5b4a7-3772-8806-4fb9-7439ad8f2c14");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_ViewTasks", new Guid("bcd5b4a7-3772-8806-4fb9-7439ad8f2c14"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef ПлановыеРаботы
			{
				get
				{
					//return new Guid("a4424c1a-5cba-9df8-4b81-5f23f7d849db");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_ViewTasks", new Guid("a4424c1a-5cba-9df8-4b81-5f23f7d849db"));
				}
			}		 
					} 
		 
		public class MovingStatus
		{
					
			public BitMobile.DbEngine.DbRef Новая
			{
				get
				{
					//return new Guid("88391333-a6f3-079d-4004-faa97d49cf1e");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_MovingStatus", new Guid("88391333-a6f3-079d-4004-faa97d49cf1e"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef Отправлена
			{
				get
				{
					//return new Guid("94f6092a-38f7-5904-4bc2-37b191fd8d72");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_MovingStatus", new Guid("94f6092a-38f7-5904-4bc2-37b191fd8d72"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef Принята
			{
				get
				{
					//return new Guid("b7bf9c5d-e005-6592-45ac-4745802d7e39");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_MovingStatus", new Guid("b7bf9c5d-e005-6592-45ac-4745802d7e39"));
				}
			}		 
					
			public BitMobile.DbEngine.DbRef Отменено
			{
				get
				{
					//return new Guid("a79183b3-1c5d-66a6-4878-d633dd9fe5e1");
					return BitMobile.DbEngine.DbRef.CreateInstance("Enum_MovingStatus", new Guid("a79183b3-1c5d-66a6-4878-d633dd9fe5e1"));
				}
			}		 
					} 
			}

	public partial class OfflineContext
	{
		private Constants.Constants _Constants = new Constants.Constants();
		public Constants.Constants Constant
		{
			get
			{
				return _Constants;
			}
		} 
	}
}