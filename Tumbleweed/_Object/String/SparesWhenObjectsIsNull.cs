using Tumbleweed._Enumerable;
using Tumbleweed._String;
using Tumbleweed.Scalar;

namespace Tumbleweed._Object.String;

public sealed class SparesWhenObjectsIsNull : EnumerableEnvelope<IString>
{
	public SparesWhenObjectsIsNull
	(
		IEnumerable<Object?> nullables,
		System.String spare
	) : this
	(
		nullables,
		new ScalarValue<System.String>(spare)
	)
	{
	}
	
	public SparesWhenObjectsIsNull
	(
		IEnumerable<Object?> nullables,
		IScalar<System.String> spare
	) : base
	(
		new SelectedByExpression<Object?, IString>(
			nullables,
			nullable => Expression(nullable, spare))
	)
	{
	}
	
	private static IString Expression
	(
		Object? nullable,
		IScalar<System.String> spare
	) =>
	(
		new SpareWhenObjectIsNull(nullable, spare)
	);
}