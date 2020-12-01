<h1>SIMPLE-SOCKS-PROXY</h1>
<h3>Make sure you download and compile CANAPE CORE before running this script !</h3>

[CANAPE CORE](https://github.com/tyranid/CANAPE.Core)

`dotnet build CANAPE.Cli/CANAPE.Cli.csproj -c Release -f netcoreapp3.0`\
`cd CANAPE.Cli/bin/Release/netcoreapp3.0`\
`dotnet exec CANAPE.Cli.dll Examples/SocksProxy.csx --color`
