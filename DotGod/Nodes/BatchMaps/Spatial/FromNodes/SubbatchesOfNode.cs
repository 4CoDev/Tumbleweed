using DotGod.Nodes.BatchMaps.Spatial.Batches;
using Godot;
using Tumbleweed.Arrays;
using Tumbleweed.Arrays.FromStorages;
using Tumbleweed.Nullability;
using Tumbleweed.Nullability.FromStorages;
using Tumbleweed.Scalars;
using Tumbleweed.Storages.Elements;

namespace DotGod.Nodes.BatchMaps.Spatial.FromNodes;

public sealed class SubbatchesOfNode :
	NullableEnvelope<IArray<ISpatialBatch>>
{
	public SubbatchesOfNode(IScalar<Node3D> node) : base
	(
		new NullableOfStorageElement<IArray<ISpatialBatch>>(
			new GlobalWithKey<INullable<IArray<ISpatialBatch>>>(
				node, "Subbatches"))
	)
	{
	}
}