using NetTopologySuite.Geometries;
using static HotChocolate.Types.Spatial.WellKnownFields;
using static HotChocolate.Types.Spatial.Properties.Resources;

namespace HotChocolate.Types.Spatial
{
    public sealed class GeoJsonMultiPolygonInput
        : GeoJsonInputObjectType<MultiPolygon>
    {
        public GeoJsonMultiPolygonInput() : base(GeoJsonGeometryType.MultiPolygon)
        {
        }

        protected override void Configure(IInputObjectTypeDescriptor<MultiPolygon> descriptor)
        {
            descriptor.GeoJsonName(nameof(GeoJsonMultiPolygonInput));

            descriptor.BindFieldsExplicitly();

            descriptor
                .Field(TypeFieldName)
                .Type<GeoJsonGeometryEnumType>()
                .Description(GeoJson_Field_Type_Description);

            descriptor
                .Field(CoordinatesFieldName)
                .Type<ListType<ListType<GeoJsonPositionType>>>()
                .Description(GeoJson_Field_Coordinates_Description_MultiPolygon);

            descriptor
                .Field(CrsFieldName)
                .Type<IntType>()
                .Description(GeoJson_Field_Crs_Description);
        }
    }
}