using Tumbleweed.Array;

namespace DotGod.Node.Batch.Dimension.Spatial.Spaced.Scalar.Value;

public sealed class One : Node.Batch.Dimension.Spatial.Spaced.Any
{
	public One(Tumbleweed.Scalar.Immutable.Any<Node.Batch.Dimension.Spatial.Spaced.Any> any) =>
		this.any = any;

	public Any<Tumbleweed.Scalar.Nullable.Any<Node.Batch.Dimension.Spatial.Unspaced.Any>> Subbatches =>
		any.Value.Subbatches;

	public ICollection<Entity.Any> Entities =>
		any.Value.Entities;

	public Space.Any Space =>
		any.Value.Space;
	
	private readonly Tumbleweed.Scalar.Immutable.Any<Node.Batch.Dimension.Spatial.Spaced.Any> any;
}