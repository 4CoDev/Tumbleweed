using Tumbleweed.Enumerable;
using Tumbleweed.Property;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Of;
using Tumbleweed.Property.Output.With.Value;
using String = Tumbleweed.String;

namespace Tumbleweed.Object.String;

public sealed class SparesWhenObjectsIsNull :
	Enumerable.Envelope<String::Any>
{
	public SparesWhenObjectsIsNull
	(
		IEnumerable<System.Object?> nullables,
		System.String spare
	) : this
	(
		nullables,
		new One<System.String>(spare)
	)
	{
	}
	
	public SparesWhenObjectsIsNull
	(
		IEnumerable<System.Object?> nullables,
		Any<System.String> spare
	) : base
	(
		new Selected<System.Object?, String::Any>(
			nullables,
			nullable => Expression(nullable, spare))
	)
	{
	}
	
	private static String::Any Expression
	(
		System.Object? nullable,
		Any<System.String> spare
	) =>
	(
		new SpareWhenObjectIsNull(nullable, spare)
	);
}