using Tumbleweed.Collection;

namespace DotGod.Node.Batch.Dimension.Spatial.Entity.Collection;

public sealed class One : CollectionEnvelope<Any>
{
	public One(Unspaced.Any batch) : base
	(
		new CollectionOfFunction<Any>(
			() => batch.Entities)
	)
	{
	}

}