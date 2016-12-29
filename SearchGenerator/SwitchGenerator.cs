namespace SearchGenerator
{
    internal static class SwitchGenerator
    {
        public static GeneratedFile GenerateSwitch(Flag[] flags)
        {
            var content = new Switch(flags).Execute();
            return new GeneratedFile { Name = "Switch.cs", Content = content};
        }
    }
}
