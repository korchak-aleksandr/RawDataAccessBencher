﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.4.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using AdventureWorks.Dal.Adapter.v54.HelperClasses;
using AdventureWorks.Dal.Adapter.v54.FactoryClasses;
using AdventureWorks.Dal.Adapter.v54.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v54.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'BusinessEntityAddress'.<br/><br/></summary>
	[Serializable]
	public partial class BusinessEntityAddressEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private AddressEntity _address;
		private AddressTypeEntity _addressType;
		private BusinessEntityEntity _businessEntity;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static BusinessEntityAddressEntityStaticMetaData _staticMetaData = new BusinessEntityAddressEntityStaticMetaData();
		private static BusinessEntityAddressRelations _relationsFactory = new BusinessEntityAddressRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Address</summary>
			public static readonly string Address = "Address";
			/// <summary>Member name AddressType</summary>
			public static readonly string AddressType = "AddressType";
			/// <summary>Member name BusinessEntity</summary>
			public static readonly string BusinessEntity = "BusinessEntity";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class BusinessEntityAddressEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public BusinessEntityAddressEntityStaticMetaData()
			{
				SetEntityCoreInfo("BusinessEntityAddressEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.v54.EntityType.BusinessEntityAddressEntity, typeof(BusinessEntityAddressEntity), typeof(BusinessEntityAddressEntityFactory), false);
				AddNavigatorMetaData<BusinessEntityAddressEntity, AddressEntity>("Address", "BusinessEntityAddresses", (a, b) => a._address = b, a => a._address, (a, b) => a.Address = b, AdventureWorks.Dal.Adapter.v54.RelationClasses.StaticBusinessEntityAddressRelations.AddressEntityUsingAddressIdStatic, ()=>new BusinessEntityAddressRelations().AddressEntityUsingAddressId, null, new int[] { (int)BusinessEntityAddressFieldIndex.AddressId }, null, true, (int)AdventureWorks.Dal.Adapter.v54.EntityType.AddressEntity);
				AddNavigatorMetaData<BusinessEntityAddressEntity, AddressTypeEntity>("AddressType", "BusinessEntityAddresses", (a, b) => a._addressType = b, a => a._addressType, (a, b) => a.AddressType = b, AdventureWorks.Dal.Adapter.v54.RelationClasses.StaticBusinessEntityAddressRelations.AddressTypeEntityUsingAddressTypeIdStatic, ()=>new BusinessEntityAddressRelations().AddressTypeEntityUsingAddressTypeId, null, new int[] { (int)BusinessEntityAddressFieldIndex.AddressTypeId }, null, true, (int)AdventureWorks.Dal.Adapter.v54.EntityType.AddressTypeEntity);
				AddNavigatorMetaData<BusinessEntityAddressEntity, BusinessEntityEntity>("BusinessEntity", "BusinessEntityAddresses", (a, b) => a._businessEntity = b, a => a._businessEntity, (a, b) => a.BusinessEntity = b, AdventureWorks.Dal.Adapter.v54.RelationClasses.StaticBusinessEntityAddressRelations.BusinessEntityEntityUsingBusinessEntityIdStatic, ()=>new BusinessEntityAddressRelations().BusinessEntityEntityUsingBusinessEntityId, null, new int[] { (int)BusinessEntityAddressFieldIndex.BusinessEntityId }, null, true, (int)AdventureWorks.Dal.Adapter.v54.EntityType.BusinessEntityEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static BusinessEntityAddressEntity()
		{
		}

		/// <summary> CTor</summary>
		public BusinessEntityAddressEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public BusinessEntityAddressEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this BusinessEntityAddressEntity</param>
		public BusinessEntityAddressEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="addressId">PK value for BusinessEntityAddress which data should be fetched into this BusinessEntityAddress object</param>
		/// <param name="addressTypeId">PK value for BusinessEntityAddress which data should be fetched into this BusinessEntityAddress object</param>
		/// <param name="businessEntityId">PK value for BusinessEntityAddress which data should be fetched into this BusinessEntityAddress object</param>
		public BusinessEntityAddressEntity(System.Int32 addressId, System.Int32 addressTypeId, System.Int32 businessEntityId) : this(addressId, addressTypeId, businessEntityId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="addressId">PK value for BusinessEntityAddress which data should be fetched into this BusinessEntityAddress object</param>
		/// <param name="addressTypeId">PK value for BusinessEntityAddress which data should be fetched into this BusinessEntityAddress object</param>
		/// <param name="businessEntityId">PK value for BusinessEntityAddress which data should be fetched into this BusinessEntityAddress object</param>
		/// <param name="validator">The custom validator object for this BusinessEntityAddressEntity</param>
		public BusinessEntityAddressEntity(System.Int32 addressId, System.Int32 addressTypeId, System.Int32 businessEntityId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.AddressId = addressId;
			this.AddressTypeId = addressTypeId;
			this.BusinessEntityId = businessEntityId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected BusinessEntityAddressEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Address' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAddress() { return CreateRelationInfoForNavigator("Address"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'AddressType' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAddressType() { return CreateRelationInfoForNavigator("AddressType"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'BusinessEntity' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBusinessEntity() { return CreateRelationInfoForNavigator("BusinessEntity"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this BusinessEntityAddressEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static BusinessEntityAddressRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Address' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAddress { get { return _staticMetaData.GetPrefetchPathElement("Address", CommonEntityBase.CreateEntityCollection<AddressEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AddressType' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAddressType { get { return _staticMetaData.GetPrefetchPathElement("AddressType", CommonEntityBase.CreateEntityCollection<AddressTypeEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'BusinessEntity' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBusinessEntity { get { return _staticMetaData.GetPrefetchPathElement("BusinessEntity", CommonEntityBase.CreateEntityCollection<BusinessEntityEntity>()); } }

		/// <summary>The AddressId property of the Entity BusinessEntityAddress<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BusinessEntityAddress"."AddressID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 AddressId
		{
			get { return (System.Int32)GetValue((int)BusinessEntityAddressFieldIndex.AddressId, true); }
			set	{ SetValue((int)BusinessEntityAddressFieldIndex.AddressId, value); }
		}

		/// <summary>The AddressTypeId property of the Entity BusinessEntityAddress<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BusinessEntityAddress"."AddressTypeID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 AddressTypeId
		{
			get { return (System.Int32)GetValue((int)BusinessEntityAddressFieldIndex.AddressTypeId, true); }
			set	{ SetValue((int)BusinessEntityAddressFieldIndex.AddressTypeId, value); }
		}

		/// <summary>The BusinessEntityId property of the Entity BusinessEntityAddress<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BusinessEntityAddress"."BusinessEntityID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 BusinessEntityId
		{
			get { return (System.Int32)GetValue((int)BusinessEntityAddressFieldIndex.BusinessEntityId, true); }
			set	{ SetValue((int)BusinessEntityAddressFieldIndex.BusinessEntityId, value); }
		}

		/// <summary>The ModifiedDate property of the Entity BusinessEntityAddress<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BusinessEntityAddress"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)BusinessEntityAddressFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)BusinessEntityAddressFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The Rowguid property of the Entity BusinessEntityAddress<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BusinessEntityAddress"."rowguid".<br/>Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)BusinessEntityAddressFieldIndex.Rowguid, true); }
			set	{ SetValue((int)BusinessEntityAddressFieldIndex.Rowguid, value); }
		}

		/// <summary>Gets / sets related entity of type 'AddressEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual AddressEntity Address
		{
			get { return _address; }
			set { SetSingleRelatedEntityNavigator(value, "Address"); }
		}

		/// <summary>Gets / sets related entity of type 'AddressTypeEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual AddressTypeEntity AddressType
		{
			get { return _addressType; }
			set { SetSingleRelatedEntityNavigator(value, "AddressType"); }
		}

		/// <summary>Gets / sets related entity of type 'BusinessEntityEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual BusinessEntityEntity BusinessEntity
		{
			get { return _businessEntity; }
			set { SetSingleRelatedEntityNavigator(value, "BusinessEntity"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
	}
}

namespace AdventureWorks.Dal.Adapter.v54
{
	public enum BusinessEntityAddressFieldIndex
	{
		///<summary>AddressId. </summary>
		AddressId,
		///<summary>AddressTypeId. </summary>
		AddressTypeId,
		///<summary>BusinessEntityId. </summary>
		BusinessEntityId,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Rowguid. </summary>
		Rowguid,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.v54.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: BusinessEntityAddress. </summary>
	public partial class BusinessEntityAddressRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between BusinessEntityAddressEntity and AddressEntity over the m:1 relation they have, using the relation between the fields: BusinessEntityAddress.AddressId - Address.AddressId</summary>
		public virtual IEntityRelation AddressEntityUsingAddressId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Address", false, new[] { AddressFields.AddressId, BusinessEntityAddressFields.AddressId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between BusinessEntityAddressEntity and AddressTypeEntity over the m:1 relation they have, using the relation between the fields: BusinessEntityAddress.AddressTypeId - AddressType.AddressTypeId</summary>
		public virtual IEntityRelation AddressTypeEntityUsingAddressTypeId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "AddressType", false, new[] { AddressTypeFields.AddressTypeId, BusinessEntityAddressFields.AddressTypeId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between BusinessEntityAddressEntity and BusinessEntityEntity over the m:1 relation they have, using the relation between the fields: BusinessEntityAddress.BusinessEntityId - BusinessEntity.BusinessEntityId</summary>
		public virtual IEntityRelation BusinessEntityEntityUsingBusinessEntityId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "BusinessEntity", false, new[] { BusinessEntityFields.BusinessEntityId, BusinessEntityAddressFields.BusinessEntityId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticBusinessEntityAddressRelations
	{
		internal static readonly IEntityRelation AddressEntityUsingAddressIdStatic = new BusinessEntityAddressRelations().AddressEntityUsingAddressId;
		internal static readonly IEntityRelation AddressTypeEntityUsingAddressTypeIdStatic = new BusinessEntityAddressRelations().AddressTypeEntityUsingAddressTypeId;
		internal static readonly IEntityRelation BusinessEntityEntityUsingBusinessEntityIdStatic = new BusinessEntityAddressRelations().BusinessEntityEntityUsingBusinessEntityId;

		/// <summary>CTor</summary>
		static StaticBusinessEntityAddressRelations() { }
	}
}
