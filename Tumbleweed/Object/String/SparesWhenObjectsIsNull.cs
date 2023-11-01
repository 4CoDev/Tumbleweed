using Tumbleweed.Enumerable;
using Tumbleweed.Property;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Of;
using Tumbleweed.Property.Output.With;
using Tumbleweed.String;

namespace Tumbleweed.Object.String;

public sealed class SparesWhenObjectsIsNull : Enumerable.Envelope<Any>
{
	public SparesWhenObjectsIsNull
	(
		IEnumerable<System.Object?> nullables,
		System.String spare
	) : this
	(
		nullables,
		new Value<System.String>(spare)
	)
	{
	}
	
	public SparesWhenObjectsIsNull
	(
		IEnumerable<System.Object?> nullables,
		Any<System.String> spare
	) : base
	(
		new Selected<System.Object?, Any>(
			nullables,
			nullable => Expression(nullable, spare))
	)
	{
	}
	
	private static Any Expression
	(
		System.Object? nullable,
		Any<System.String> spare
	) =>
	(
		new SpareWhenObjectIsNull(nullable, spare)
	);
}