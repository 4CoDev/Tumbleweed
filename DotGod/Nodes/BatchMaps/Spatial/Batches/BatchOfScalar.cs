using DotGod.Nodes.BatchMaps.Spatial.Entities;
using Tumbleweed.Arrays;
using Tumbleweed.Nullability;
using Tumbleweed.Scalars;

namespace DotGod.Nodes.BatchMaps.Spatial.Batches;

public sealed class BatchOfScalar : ISpatialBatch
{
	public BatchOfScalar(IScalar<ISpatialBatch> scalar) =>
		this.scalar = scalar;

	public INullable<IArray<ISpatialBatch>> Subbatches =>
		scalar.Value.Subbatches;

	public ICollection<ISpatialEntity> Entities =>
		scalar.Value.Entities;

	private readonly IScalar<ISpatialBatch> scalar;
}