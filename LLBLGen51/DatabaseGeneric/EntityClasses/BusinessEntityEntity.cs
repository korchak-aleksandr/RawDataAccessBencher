﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Xml.Serialization;
using AdventureWorks.Dal.Adapter.v51;
using AdventureWorks.Dal.Adapter.v51.HelperClasses;
using AdventureWorks.Dal.Adapter.v51.FactoryClasses;
using AdventureWorks.Dal.Adapter.v51.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v51.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'BusinessEntity'.<br/><br/></summary>
	[Serializable]
	public partial class BusinessEntityEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<BusinessEntityAddressEntity> _businessEntityAddresses;
		private EntityCollection<BusinessEntityContactEntity> _businessEntityContacts;
		private PersonEntity _person;
		private StoreEntity _store;
		private VendorEntity _vendor;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name BusinessEntityAddresses</summary>
			public static readonly string BusinessEntityAddresses = "BusinessEntityAddresses";
			/// <summary>Member name BusinessEntityContacts</summary>
			public static readonly string BusinessEntityContacts = "BusinessEntityContacts";
			/// <summary>Member name Person</summary>
			public static readonly string Person = "Person";
			/// <summary>Member name Store</summary>
			public static readonly string Store = "Store";
			/// <summary>Member name Vendor</summary>
			public static readonly string Vendor = "Vendor";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static BusinessEntityEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public BusinessEntityEntity():base("BusinessEntityEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public BusinessEntityEntity(IEntityFields2 fields):base("BusinessEntityEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this BusinessEntityEntity</param>
		public BusinessEntityEntity(IValidator validator):base("BusinessEntityEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="businessEntityId">PK value for BusinessEntity which data should be fetched into this BusinessEntity object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public BusinessEntityEntity(System.Int32 businessEntityId):base("BusinessEntityEntity")
		{
			InitClassEmpty(null, null);
			this.BusinessEntityId = businessEntityId;
		}

		/// <summary> CTor</summary>
		/// <param name="businessEntityId">PK value for BusinessEntity which data should be fetched into this BusinessEntity object</param>
		/// <param name="validator">The custom validator object for this BusinessEntityEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public BusinessEntityEntity(System.Int32 businessEntityId, IValidator validator):base("BusinessEntityEntity")
		{
			InitClassEmpty(validator, null);
			this.BusinessEntityId = businessEntityId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected BusinessEntityEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_businessEntityAddresses = (EntityCollection<BusinessEntityAddressEntity>)info.GetValue("_businessEntityAddresses", typeof(EntityCollection<BusinessEntityAddressEntity>));
				_businessEntityContacts = (EntityCollection<BusinessEntityContactEntity>)info.GetValue("_businessEntityContacts", typeof(EntityCollection<BusinessEntityContactEntity>));
				_person = (PersonEntity)info.GetValue("_person", typeof(PersonEntity));
				if(_person!=null)
				{
					_person.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_store = (StoreEntity)info.GetValue("_store", typeof(StoreEntity));
				if(_store!=null)
				{
					_store.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_vendor = (VendorEntity)info.GetValue("_vendor", typeof(VendorEntity));
				if(_vendor!=null)
				{
					_vendor.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}


		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "BusinessEntityAddresses":
					this.BusinessEntityAddresses.Add((BusinessEntityAddressEntity)entity);
					break;
				case "BusinessEntityContacts":
					this.BusinessEntityContacts.Add((BusinessEntityContactEntity)entity);
					break;
				case "Person":
					this.Person = (PersonEntity)entity;
					break;
				case "Store":
					this.Store = (StoreEntity)entity;
					break;
				case "Vendor":
					this.Vendor = (VendorEntity)entity;
					break;
				default:
					this.OnSetRelatedEntityProperty(propertyName, entity);
					break;
			}
		}
		
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		protected override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		internal static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "BusinessEntityAddresses":
					toReturn.Add(Relations.BusinessEntityAddressEntityUsingBusinessEntityId);
					break;
				case "BusinessEntityContacts":
					toReturn.Add(Relations.BusinessEntityContactEntityUsingBusinessEntityId);
					break;
				case "Person":
					toReturn.Add(Relations.PersonEntityUsingBusinessEntityId);
					break;
				case "Store":
					toReturn.Add(Relations.StoreEntityUsingCustomerId);
					break;
				case "Vendor":
					toReturn.Add(Relations.VendorEntityUsingVendorId);
					break;
				default:
					break;				
			}
			return toReturn;
		}
#if !CF
		/// <summary>Checks if the relation mapped by the property with the name specified is a one way / single sided relation. If the passed in name is null, it/ will return true if the entity has any single-sided relation</summary>
		/// <param name="propertyName">Name of the property which is mapped onto the relation to check, or null to check if the entity has any relation/ which is single sided</param>
		/// <returns>true if the relation is single sided / one way (so the opposite relation isn't present), false otherwise</returns>
		protected override bool CheckOneWayRelations(string propertyName)
		{
			int numberOfOneWayRelations = 0;
			switch(propertyName)
			{
				case null:
					return ((numberOfOneWayRelations > 0) || base.CheckOneWayRelations(null));
				default:
					return base.CheckOneWayRelations(propertyName);
			}
		}
#endif
		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "BusinessEntityAddresses":
					this.BusinessEntityAddresses.Add((BusinessEntityAddressEntity)relatedEntity);
					break;
				case "BusinessEntityContacts":
					this.BusinessEntityContacts.Add((BusinessEntityContactEntity)relatedEntity);
					break;
				case "Person":
					SetupSyncPerson(relatedEntity);
					break;
				case "Store":
					SetupSyncStore(relatedEntity);
					break;
				case "Vendor":
					SetupSyncVendor(relatedEntity);
					break;
				default:
					break;
			}
		}

		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		protected override void UnsetRelatedEntity(IEntityCore relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "BusinessEntityAddresses":
					this.PerformRelatedEntityRemoval(this.BusinessEntityAddresses, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "BusinessEntityContacts":
					this.PerformRelatedEntityRemoval(this.BusinessEntityContacts, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Person":
					DesetupSyncPerson(false, true);
					break;
				case "Store":
					DesetupSyncStore(false, true);
					break;
				case "Vendor":
					DesetupSyncVendor(false, true);
					break;
				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependingRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			if(_person!=null)
			{
				toReturn.Add(_person);
			}

			if(_store!=null)
			{
				toReturn.Add(_store);
			}

			if(_vendor!=null)
			{
				toReturn.Add(_vendor);
			}

			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependentRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();






			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.BusinessEntityAddresses);
			toReturn.Add(this.BusinessEntityContacts);
			return toReturn;
		}

		/// <summary>ISerializable member. Does custom serialization so event handlers do not get serialized. Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				info.AddValue("_businessEntityAddresses", ((_businessEntityAddresses!=null) && (_businessEntityAddresses.Count>0) && !this.MarkedForDeletion)?_businessEntityAddresses:null);
				info.AddValue("_businessEntityContacts", ((_businessEntityContacts!=null) && (_businessEntityContacts.Count>0) && !this.MarkedForDeletion)?_businessEntityContacts:null);
				info.AddValue("_person", (!this.MarkedForDeletion?_person:null));
				info.AddValue("_store", (!this.MarkedForDeletion?_store:null));
				info.AddValue("_vendor", (!this.MarkedForDeletion?_vendor:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new BusinessEntityRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'BusinessEntityAddress' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBusinessEntityAddresses()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(BusinessEntityAddressFields.BusinessEntityId, null, ComparisonOperator.Equal, this.BusinessEntityId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'BusinessEntityContact' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBusinessEntityContacts()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(BusinessEntityContactFields.BusinessEntityId, null, ComparisonOperator.Equal, this.BusinessEntityId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Person' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPerson()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PersonFields.BusinessEntityId, null, ComparisonOperator.Equal, this.BusinessEntityId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Store' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoStore()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(StoreFields.CustomerId, null, ComparisonOperator.Equal, this.BusinessEntityId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Vendor' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoVendor()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(VendorFields.VendorId, null, ComparisonOperator.Equal, this.BusinessEntityId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(BusinessEntityEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._businessEntityAddresses);
			collectionsQueue.Enqueue(this._businessEntityContacts);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._businessEntityAddresses = (EntityCollection<BusinessEntityAddressEntity>) collectionsQueue.Dequeue();
			this._businessEntityContacts = (EntityCollection<BusinessEntityContactEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._businessEntityAddresses != null);
			toReturn |=(this._businessEntityContacts != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<BusinessEntityAddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BusinessEntityAddressEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<BusinessEntityContactEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BusinessEntityContactEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("BusinessEntityAddresses", _businessEntityAddresses);
			toReturn.Add("BusinessEntityContacts", _businessEntityContacts);
			toReturn.Add("Person", _person);
			toReturn.Add("Store", _store);
			toReturn.Add("Vendor", _vendor);
			return toReturn;
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}


		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BusinessEntityId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _person</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncPerson(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _person, new PropertyChangedEventHandler( OnPersonPropertyChanged ), "Person", AdventureWorks.Dal.Adapter.v51.RelationClasses.StaticBusinessEntityRelations.PersonEntityUsingBusinessEntityIdStatic, false, signalRelatedEntity, "BusinessEntity", false, new int[] { (int)BusinessEntityFieldIndex.BusinessEntityId } );
			_person = null;
		}
		
		/// <summary> setups the sync logic for member _person</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncPerson(IEntityCore relatedEntity)
		{
			if(_person!=relatedEntity)
			{
				DesetupSyncPerson(true, true);
				_person = (PersonEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _person, new PropertyChangedEventHandler( OnPersonPropertyChanged ), "Person", AdventureWorks.Dal.Adapter.v51.RelationClasses.StaticBusinessEntityRelations.PersonEntityUsingBusinessEntityIdStatic, false, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnPersonPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _store</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncStore(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _store, new PropertyChangedEventHandler( OnStorePropertyChanged ), "Store", AdventureWorks.Dal.Adapter.v51.RelationClasses.StaticBusinessEntityRelations.StoreEntityUsingCustomerIdStatic, false, signalRelatedEntity, "BusinessEntity", false, new int[] { (int)BusinessEntityFieldIndex.BusinessEntityId } );
			_store = null;
		}
		
		/// <summary> setups the sync logic for member _store</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncStore(IEntityCore relatedEntity)
		{
			if(_store!=relatedEntity)
			{
				DesetupSyncStore(true, true);
				_store = (StoreEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _store, new PropertyChangedEventHandler( OnStorePropertyChanged ), "Store", AdventureWorks.Dal.Adapter.v51.RelationClasses.StaticBusinessEntityRelations.StoreEntityUsingCustomerIdStatic, false, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnStorePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _vendor</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncVendor(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _vendor, new PropertyChangedEventHandler( OnVendorPropertyChanged ), "Vendor", AdventureWorks.Dal.Adapter.v51.RelationClasses.StaticBusinessEntityRelations.VendorEntityUsingVendorIdStatic, false, signalRelatedEntity, "BusinessEntity", false, new int[] { (int)BusinessEntityFieldIndex.BusinessEntityId } );
			_vendor = null;
		}
		
		/// <summary> setups the sync logic for member _vendor</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncVendor(IEntityCore relatedEntity)
		{
			if(_vendor!=relatedEntity)
			{
				DesetupSyncVendor(true, true);
				_vendor = (VendorEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _vendor, new PropertyChangedEventHandler( OnVendorPropertyChanged ), "Vendor", AdventureWorks.Dal.Adapter.v51.RelationClasses.StaticBusinessEntityRelations.VendorEntityUsingVendorIdStatic, false, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnVendorPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this BusinessEntityEntity</param>
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

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static BusinessEntityRelations Relations
		{
			get	{ return new BusinessEntityRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'BusinessEntityAddress' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBusinessEntityAddresses
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<BusinessEntityAddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BusinessEntityAddressEntityFactory))), (IEntityRelation)GetRelationsForField("BusinessEntityAddresses")[0], (int)AdventureWorks.Dal.Adapter.v51.EntityType.BusinessEntityEntity, (int)AdventureWorks.Dal.Adapter.v51.EntityType.BusinessEntityAddressEntity, 0, null, null, null, null, "BusinessEntityAddresses", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'BusinessEntityContact' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBusinessEntityContacts
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<BusinessEntityContactEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BusinessEntityContactEntityFactory))), (IEntityRelation)GetRelationsForField("BusinessEntityContacts")[0], (int)AdventureWorks.Dal.Adapter.v51.EntityType.BusinessEntityEntity, (int)AdventureWorks.Dal.Adapter.v51.EntityType.BusinessEntityContactEntity, 0, null, null, null, null, "BusinessEntityContacts", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Person' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPerson
		{
			get { return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(PersonEntityFactory))), (IEntityRelation)GetRelationsForField("Person")[0], (int)AdventureWorks.Dal.Adapter.v51.EntityType.BusinessEntityEntity, (int)AdventureWorks.Dal.Adapter.v51.EntityType.PersonEntity, 0, null, null, null, null, "Person", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Store' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathStore
		{
			get { return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(StoreEntityFactory))), (IEntityRelation)GetRelationsForField("Store")[0], (int)AdventureWorks.Dal.Adapter.v51.EntityType.BusinessEntityEntity, (int)AdventureWorks.Dal.Adapter.v51.EntityType.StoreEntity, 0, null, null, null, null, "Store", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Vendor' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathVendor
		{
			get { return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(VendorEntityFactory))), (IEntityRelation)GetRelationsForField("Vendor")[0], (int)AdventureWorks.Dal.Adapter.v51.EntityType.BusinessEntityEntity, (int)AdventureWorks.Dal.Adapter.v51.EntityType.VendorEntity, 0, null, null, null, null, "Vendor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne);	}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return FieldsCustomProperties;}
		}

		/// <summary> The BusinessEntityId property of the Entity BusinessEntity<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BusinessEntity"."BusinessEntityID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 BusinessEntityId
		{
			get { return (System.Int32)GetValue((int)BusinessEntityFieldIndex.BusinessEntityId, true); }
			set	{ SetValue((int)BusinessEntityFieldIndex.BusinessEntityId, value); }
		}

		/// <summary> The ModifiedDate property of the Entity BusinessEntity<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BusinessEntity"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)BusinessEntityFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)BusinessEntityFieldIndex.ModifiedDate, value); }
		}

		/// <summary> The Rowguid property of the Entity BusinessEntity<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BusinessEntity"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)BusinessEntityFieldIndex.Rowguid, true); }
			set	{ SetValue((int)BusinessEntityFieldIndex.Rowguid, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'BusinessEntityAddressEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(BusinessEntityAddressEntity))]
		public virtual EntityCollection<BusinessEntityAddressEntity> BusinessEntityAddresses
		{
			get { return GetOrCreateEntityCollection<BusinessEntityAddressEntity, BusinessEntityAddressEntityFactory>("BusinessEntity", true, false, ref _businessEntityAddresses);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'BusinessEntityContactEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(BusinessEntityContactEntity))]
		public virtual EntityCollection<BusinessEntityContactEntity> BusinessEntityContacts
		{
			get { return GetOrCreateEntityCollection<BusinessEntityContactEntity, BusinessEntityContactEntityFactory>("BusinessEntity", true, false, ref _businessEntityContacts);	}
		}

		/// <summary> Gets / sets related entity of type 'PersonEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned.<br/><br/>
		/// </summary>
		[Browsable(false)]
		public virtual PersonEntity Person
		{
			get { return _person; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncPerson(value);
					CallSetRelatedEntityDuringDeserialization(value, "BusinessEntity");
				}
				else
				{
					if(value==null)
					{
						bool raisePropertyChanged = (_person !=null);
						DesetupSyncPerson(true, true);
						if(raisePropertyChanged)
						{
							OnPropertyChanged("Person");
						}
					}
					else
					{
						if(_person!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "BusinessEntity");
							SetupSyncPerson(value);
						}
					}
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'StoreEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned.<br/><br/>
		/// </summary>
		[Browsable(false)]
		public virtual StoreEntity Store
		{
			get { return _store; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncStore(value);
					CallSetRelatedEntityDuringDeserialization(value, "BusinessEntity");
				}
				else
				{
					if(value==null)
					{
						bool raisePropertyChanged = (_store !=null);
						DesetupSyncStore(true, true);
						if(raisePropertyChanged)
						{
							OnPropertyChanged("Store");
						}
					}
					else
					{
						if(_store!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "BusinessEntity");
							SetupSyncStore(value);
						}
					}
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'VendorEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned.<br/><br/>
		/// </summary>
		[Browsable(false)]
		public virtual VendorEntity Vendor
		{
			get { return _vendor; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncVendor(value);
					CallSetRelatedEntityDuringDeserialization(value, "BusinessEntity");
				}
				else
				{
					if(value==null)
					{
						bool raisePropertyChanged = (_vendor !=null);
						DesetupSyncVendor(true, true);
						if(raisePropertyChanged)
						{
							OnPropertyChanged("Vendor");
						}
					}
					else
					{
						if(_vendor!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "BusinessEntity");
							SetupSyncVendor(value);
						}
					}
				}
			}
		}
	
		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}
		
		/// <summary>Returns the AdventureWorks.Dal.Adapter.v51.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)AdventureWorks.Dal.Adapter.v51.EntityType.BusinessEntityEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
