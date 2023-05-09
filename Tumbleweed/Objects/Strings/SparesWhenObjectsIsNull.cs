using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Objects.Strings;

public sealed class SparesWhenObjectsIsNull : EnumerableEnvelope<String>
{
	public SparesWhenObjectsIsNull
	(
		IEnumerable<Object?> nullables,
		String spare
	) : this
	(
		nullables,
		new ScalarValue<String>(spare)
	)
	{
	}
	
	public SparesWhenObjectsIsNull
	(
		IEnumerable<Object?> nullables,
		IScalar<String> spare
	) : base
	(
		new SelectedByExpression<Object?, String>(
			nullables,
			nullable => new SpareWhenObjectIsNull(nullable, spare).Value)
	)
	{
	}
}