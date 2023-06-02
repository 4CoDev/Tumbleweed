using Godot;
using Tumbleweed.Array;
using Tumbleweed.Nullable;
using Tumbleweed.Nullable.FromStorage;
using Tumbleweed.Scalar;
using Tumbleweed.Storage.Element;

namespace DotGod.Spatial._Node.Batch.FromNodes;

public sealed class SubbatchesOfNode :
	NullableEnvelope<IArray<IBatch>>
{
	public SubbatchesOfNode(IScalar<Node3D> node) : base
	(
		new NullableOfStorageElement<IArray<IBatch>>(
			new GlobalWithKey<INullable<IArray<IBatch>>>(
				node, "Subbatches"))
	)
	{
	}
}