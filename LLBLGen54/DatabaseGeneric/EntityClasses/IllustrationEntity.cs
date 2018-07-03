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
	/// <summary>Entity class which represents the entity 'Illustration'.<br/><br/></summary>
	[Serializable]
	public partial class IllustrationEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<ProductModelIllustrationEntity> _productModelIllustrations;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static IllustrationEntityStaticMetaData _staticMetaData = new IllustrationEntityStaticMetaData();
		private static IllustrationRelations _relationsFactory = new IllustrationRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name ProductModelIllustrations</summary>
			public static readonly string ProductModelIllustrations = "ProductModelIllustrations";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class IllustrationEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public IllustrationEntityStaticMetaData()
			{
				SetEntityCoreInfo("IllustrationEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.v54.EntityType.IllustrationEntity, typeof(IllustrationEntity), typeof(IllustrationEntityFactory), false);
				AddNavigatorMetaData<IllustrationEntity, EntityCollection<ProductModelIllustrationEntity>>("ProductModelIllustrations", a => a._productModelIllustrations, (a, b) => a._productModelIllustrations = b, a => a.ProductModelIllustrations, () => new IllustrationRelations().ProductModelIllustrationEntityUsingIllustrationId, typeof(ProductModelIllustrationEntity), (int)AdventureWorks.Dal.Adapter.v54.EntityType.ProductModelIllustrationEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static IllustrationEntity()
		{
		}

		/// <summary> CTor</summary>
		public IllustrationEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public IllustrationEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this IllustrationEntity</param>
		public IllustrationEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="illustrationId">PK value for Illustration which data should be fetched into this Illustration object</param>
		public IllustrationEntity(System.Int32 illustrationId) : this(illustrationId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="illustrationId">PK value for Illustration which data should be fetched into this Illustration object</param>
		/// <param name="validator">The custom validator object for this IllustrationEntity</param>
		public IllustrationEntity(System.Int32 illustrationId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.IllustrationId = illustrationId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected IllustrationEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductModelIllustration' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductModelIllustrations() { return CreateRelationInfoForNavigator("ProductModelIllustrations"); }
		
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
		/// <param name="validator">The validator object for this IllustrationEntity</param>
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
		public static IllustrationRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductModelIllustration' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductModelIllustrations { get { return _staticMetaData.GetPrefetchPathElement("ProductModelIllustrations", CommonEntityBase.CreateEntityCollection<ProductModelIllustrationEntity>()); } }

		/// <summary>The Diagram property of the Entity Illustration<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Illustration"."Diagram".<br/>Table field type characteristics (type, precision, scale, length): Xml, 0, 0, 2147483647.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Diagram
		{
			get { return (System.String)GetValue((int)IllustrationFieldIndex.Diagram, true); }
			set	{ SetValue((int)IllustrationFieldIndex.Diagram, value); }
		}

		/// <summary>The IllustrationId property of the Entity Illustration<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Illustration"."IllustrationID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 IllustrationId
		{
			get { return (System.Int32)GetValue((int)IllustrationFieldIndex.IllustrationId, true); }
			set { SetValue((int)IllustrationFieldIndex.IllustrationId, value); }		}

		/// <summary>The ModifiedDate property of the Entity Illustration<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Illustration"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)IllustrationFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)IllustrationFieldIndex.ModifiedDate, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'ProductModelIllustrationEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductModelIllustrationEntity))]
		public virtual EntityCollection<ProductModelIllustrationEntity> ProductModelIllustrations { get { return GetOrCreateEntityCollection<ProductModelIllustrationEntity, ProductModelIllustrationEntityFactory>("Illustration", true, false, ref _productModelIllustrations); } }

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
	}
}

namespace AdventureWorks.Dal.Adapter.v54
{
	public enum IllustrationFieldIndex
	{
		///<summary>Diagram. </summary>
		Diagram,
		///<summary>IllustrationId. </summary>
		IllustrationId,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.v54.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Illustration. </summary>
	public partial class IllustrationRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between IllustrationEntity and ProductModelIllustrationEntity over the 1:n relation they have, using the relation between the fields: Illustration.IllustrationId - ProductModelIllustration.IllustrationId</summary>
		public virtual IEntityRelation ProductModelIllustrationEntityUsingIllustrationId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "ProductModelIllustrations", true, new[] { IllustrationFields.IllustrationId, ProductModelIllustrationFields.IllustrationId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticIllustrationRelations
	{
		internal static readonly IEntityRelation ProductModelIllustrationEntityUsingIllustrationIdStatic = new IllustrationRelations().ProductModelIllustrationEntityUsingIllustrationId;

		/// <summary>CTor</summary>
		static StaticIllustrationRelations() { }
	}
}
