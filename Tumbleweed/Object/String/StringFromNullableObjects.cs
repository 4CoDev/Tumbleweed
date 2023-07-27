using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.String;
using Tumbleweed.String;
using Tumbleweed.String.From.System.NonNullable;
using Envelope = Tumbleweed.String.Envelope;

namespace Tumbleweed.Object.String;

public sealed class StringFromNullableObjects : Envelope
{
	public StringFromNullableObjects(params System.Object?[] objects) : this
	(
		new Concatenated<System.Object?>(objects)
	)
	{
	}
	
	public StringFromNullableObjects(IEnumerable<System.Object?> objects) : base
	(
		new Conсatenated(
			new CommaSeparated(
				new SparesWhenObjectsIsNull(objects, "null")),
			new One("."))
	)
	{
	}
}