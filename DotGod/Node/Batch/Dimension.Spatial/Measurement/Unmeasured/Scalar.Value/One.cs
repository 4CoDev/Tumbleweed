using Tumbleweed.Array.Dimension.Multi;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured.Property.Value;

public sealed class One : Any
{
	public One(Tumbleweed.Property.Output.Any<Any> property) =>
		this.property = property;

	public Any<Tumbleweed.Property.Nullable.Any<Any>> Subbatches =>
		property.Value.Subbatches;

	public ICollection<Entity.Any> Entities =>
		property.Value.Entities;

	private readonly Tumbleweed.Property.Output.Any<Any> property;
}