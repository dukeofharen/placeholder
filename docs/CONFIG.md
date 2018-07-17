# Configuration

This page contains all command line arguments supported by HttPlaceholder. Configuration can be set using command line arguments and a configuration file.

## Command line arguments

### Input file (optional)

```
httplaceholder --inputFile C:\path\to\file.yml
```

```
httplaceholder --inputFile C:\path\to\stubsfolder
```

For input file, you can both provide a path to a .yml file (to load only that file) or provide a path to a folder containing .yml files (which will all be loaded in that case).

### Use HTTPS (optional)

```
httplaceholder --useHttps true
```

Whether to also use HTTPS. Possible values: `true` or `false`. Default: `false`

### HTTPS certificates (optional)

```
httplaceholder --pfxPath C:\path\to\privatekey.pfx --pfxPassword 11223344
```

Define the private key used for hosting the stub with HTTPS. If no pfx path and pfx password are set, the default .pfx file, shipped with HttPlaceholder, is used.

### HTTP(S) port (optional)

```
httplaceholder --port 80 --httpsPort 443 --useHttps true
```

Defines which ports the stub should be available at. Default value of `port` (the HTTP port) is `5000` and default value of `httpsPort` is `5050`.

### Request logging (optional)

```
httplaceholder --oldRequestsQueueLength 100
```

The maximum number of HTTP requests that the in memory stub source (used for the REST API) should store before truncating old records. Default: 40.

### REST API Authentication (optional)

```
httplaceholder --apiUsername user --apiPassword pass
```

The username and password that should be sent (using basic authentication) when communicating with the REST API. If these values are not set, the API is available for everyone.

### Enable / disable request logging on the terminal (optional)

```
httplaceholder --enableRequestLogging false
```

If this property is set to false, no detailed request logging will be written to the terminal anymore. Default: true.

## Configuration file

If you just installed HttPlaceholder, a file called `_config.json` is available in the installation folder. If you rename this file to `config.json`, and you don't pass any comand line arguments to HttPlaceholder, the application will try to read and parse this file. The file uses the same configuration names as the names you use when passing the values on the command line. An example of a configuration file:

```
{
    "apiUsername": null,
    "apiPassword": null,
    "httpsPort": 5050,
    "inputFile": null,
    "oldRequestsQueueLength": 40,
    "pfxPassword": null,
    "pfxPath": null,
    "port": 5000,
    "useHttps": false,
    "enableRequestLogging": true
}
```