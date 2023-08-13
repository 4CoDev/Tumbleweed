using Tumbleweed.Scalar.Nullable;

namespace DotGod.Node.Batch.Dimension.Spatial.Spaced.With.Members;

public sealed class One : Any
{
	public One
	(
		Tumbleweed.Array.Any<Any<Unspaced.Any>> subbatches,
		ICollection<Entity.Any> entities,
		Space.Any space
	)
	{
		Subbatches = subbatches;
		Entities = entities;
		Space = space;
	}
	
	public Tumbleweed.Array.Any<Any<Unspaced.Any>> Subbatches { get; }

	public ICollection<Entity.Any> Entities { get; }

	public Space.Any Space { get; }
}