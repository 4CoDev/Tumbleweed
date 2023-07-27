using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.String;
using Tumbleweed.String;
using Tumbleweed.String.From.System.NonNullable;
using Envelope = Tumbleweed.String.Envelope;

namespace Tumbleweed.Object.String;

public sealed class StringFromObjects : Envelope
{
	public StringFromObjects(params System.Object[] objects) : this
	(
		new Concatenated<System.Object>(objects)
	)
	{
	}
	
	public StringFromObjects(IEnumerable<System.Object> objects) : base
	(
		new Conсatenated(
			new CommaSeparated(
				new StringsFromObjects(objects)),
			new One("."))
	)
	{
	}
}