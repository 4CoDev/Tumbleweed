using Godot;
using Tumbleweed.Enumerable.Storage.Record.Value;
using Tumbleweed.Storage.Record.By.Key;

namespace DotGod.Node.Spatial.Batch.Entities.FromNodes.Nodes;

public sealed class CurrentOfBatch : Tumbleweed.Enumerable.Envelope<Godot.Node>
{
	public CurrentOfBatch(Tumbleweed.Scalar.Immutable.Any<Node3D> space) : base
	(
		new NonNullable<Godot.Node>(
			new Global<IEnumerable<Godot.Node>>(
				space, "Entities.Nodes.Current"))
	)
	{
	}
}