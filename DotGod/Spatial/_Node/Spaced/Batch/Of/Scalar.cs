using DotGod.Spatial._Node.Batch;
using DotGod.Spatial._Node.Batch.Entities;
using DotGod.Spatial._Node.Batch.Space;
using Tumbleweed.Array;

namespace DotGod.Spatial._Node.Spaced.Batch.Of;

public sealed class Scalar : Abstract.IBatch
{
	public Scalar(Tumbleweed.Scalar.Any<Abstract.IBatch> any) =>
		this.any = any;

	public Any<Tumbleweed.Nullable.Any<Any>> Subbatches =>
		any.Value.Subbatches;

	public ICollection<ISpatialEntity> Entities =>
		any.Value.Entities;

	public ISpace Space =>
		any.Value.Space;
	
	private readonly Tumbleweed.Scalar.Any<Abstract.IBatch> any;
}