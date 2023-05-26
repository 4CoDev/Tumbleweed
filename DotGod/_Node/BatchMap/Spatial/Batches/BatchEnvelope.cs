using DotGod._Node.BatchMap.Spatial.Entities;
using Tumbleweed.Array;
using Tumbleweed.Nullable;

namespace DotGod._Node.BatchMap.Spatial.Batches;

public abstract class BatchEnvelope : IBatch
{
	protected BatchEnvelope(IBatch space) =>
		this.space = space;

	public override Boolean Equals(Object? @object) =>
		space.Equals(@object);

	public override Int32 GetHashCode() =>
		space.GetHashCode();

	public override String? ToString() =>
		space.ToString();

	public INullable<IArray<IBatch>> Subbatches =>
		space.Subbatches;
	
	public ICollection<ISpatialEntity> Entities =>
		space.Entities;

	private readonly IBatch space;
}