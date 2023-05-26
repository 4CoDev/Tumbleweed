using DotGod._Node.BatchMap.Spatial.Entities;
using Tumbleweed.Array;
using Tumbleweed.Nullable;
using Tumbleweed.Scalar;

namespace DotGod._Node.BatchMap.Spatial.Batches;

public sealed class BatchOfScalar : IBatch
{
	public BatchOfScalar(IScalar<IBatch> scalar) =>
		this.scalar = scalar;

	public INullable<IArray<IBatch>> Subbatches =>
		scalar.Value.Subbatches;

	public ICollection<ISpatialEntity> Entities =>
		scalar.Value.Entities;

	private readonly IScalar<IBatch> scalar;
}