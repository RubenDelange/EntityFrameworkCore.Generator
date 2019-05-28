using System.ComponentModel;

namespace EntityFrameworkCore.Generator.Options
{
    /// <summary>
    /// EntityFramework entity class generation options
    /// </summary>
    /// <seealso cref="ClassOptionsBase" />
    public class EntityClassOptions : ClassOptionsBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityClassOptions"/> class.
        /// </summary>
        public EntityClassOptions(VariableDictionary variables, string prefix)
            : base(variables, AppendPrefix(prefix, "Entity"))
        {
            Namespace = "{Project.Namespace}.Data.Entities";
            Directory = @"{Project.Directory}\Data\Entities";

            RelationshipNaming = RelationshipNaming.Plural;
            EntityNaming = EntityNaming.Singular;
            PrefixWithSchemaName = false;
            AddIgnoreMapAttributeOnChildren = true;
            AddReadOnlyIdProperty = false;

            Include = new SelectionOptions();
            Exclude = new SelectionOptions();
        }

        /// <summary>
        /// Gets or sets the base class to inherit from.
        /// </summary>
        /// <value>
        /// The base class.
        /// </value>
        public string BaseClass
        {
            get => GetProperty();
            set => SetProperty(value);
        }

        /// <summary>
        /// Gets or sets the entity class naming strategy.
        /// </summary>
        /// <value>
        /// The entity class naming strategy.
        /// </value>
        [DefaultValue(EntityNaming.Singular)]
        public EntityNaming EntityNaming { get; set; }

        /// <summary>
        /// Gets or sets the relationship property naming strategy.
        /// </summary>
        /// <value>
        /// The relationship property naming strategy.
        /// </value>
        [DefaultValue(RelationshipNaming.Plural)]
        public RelationshipNaming RelationshipNaming { get; set; }

        /// <summary>
        /// If true prefix classname with schema name to prevent naming conflicts
        /// </summary>
        [DefaultValue(false)]
        public bool PrefixWithSchemaName { get; set; }

        /// <summary>
        /// Additional using statements, ;-separated - example: MyLib;MyLib.Data;MyLib.Domain
        /// </summary>
        public string AdditionalUsings { get; set; }

        /// <summary>
        /// If true, [IgnoreMap] will be set on each child attribute (1-1 and 1-n relations)
        /// </summary>
        [DefaultValue(true)]
        public bool AddIgnoreMapAttributeOnChildren { get; set; }

        /// <summary>
        /// If true, a property public Guid Id => {EntityClassName}Id; will be added
        /// </summary>
        [DefaultValue(false)]
        public bool AddReadOnlyIdProperty { get; set; }

        /// <summary>
        /// Gets or sets the include selection options.
        /// </summary>
        /// <value>
        /// The include selection options.
        /// </value>
        public SelectionOptions Include { get; set; }

        /// <summary>
        /// Gets or sets the exclude selection options.
        /// </summary>
        /// <value>
        /// The exclude selection options.
        /// </value>
        public SelectionOptions Exclude { get; set; }
    }
}