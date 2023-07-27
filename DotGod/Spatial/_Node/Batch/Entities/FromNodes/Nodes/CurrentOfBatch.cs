using Godot;
using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Storage;
using Tumbleweed.Enumerable.Storage.Record.Value;
using Tumbleweed.Scalar;
using Tumbleweed.Storage.Record;
using Tumbleweed.Storage.Record.By.Key;

namespace DotGod.Spatial._Node.Batch.Entities.FromNodes.Nodes;

public sealed class CurrentOfBatch : Tumbleweed.Enumerable.Envelope<Godot.Node>
{
	public CurrentOfBatch(Tumbleweed.Scalar.Any<Node3D> space) : base
	(
		new NonNullable<Godot.Node>(
			new Global<IEnumerable<Godot.Node>>(
				space, "Entities.Nodes.Current"))
	)
	{
	}
}