using Godot;
using Tumbleweed.Array;
using Tumbleweed.Array.Storage.Record.Value;
using Tumbleweed.Storage.Record;
using Tumbleweed.Storage.Record.By.Key;

namespace DotGod.Spatial._Node.Batch.FromNodes;

public sealed class SubbatchesOfNode : Tumbleweed.Array.Envelope<Tumbleweed.Nullable.Any<Any>>
{
	public SubbatchesOfNode(Tumbleweed.Scalar.Any<Node3D> node) : base
	(
		new NonNullable<Tumbleweed.Nullable.Any<Any>>(
			new Global<Tumbleweed.Array.Any<Tumbleweed.Nullable.Any<Any>>>(
				node, "Subbatches"))
	)
	{
	}
}