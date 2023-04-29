using Godot;
using TumbleGD.Nodes.BatchMaps.Spatial.Batches;
using Tumbleweed.Arrays;
using Tumbleweed.Arrays.FromStorages;
using Tumbleweed.Nullability;
using Tumbleweed.Nullability.FromStorages;
using Tumbleweed.Scalars;
using Tumbleweed.Storages.Elements;

namespace TumbleGD.Nodes.BatchMaps.Spatial.FromNodes;

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