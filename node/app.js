var http = require('http');
var sleep = require('system-sleep');
var os = require('os');
var hostname = os.hostname();

http.createServer((req, res) => {
    sleep(1);
    res.writeHead(200, { 'Content-Type': 'text/plain' });
    res.end('Swarm svc (Node app), hostname= ' + hostname);
}).listen(8085);

console.log("Node app, listening port 8085, hostname= " + hostname);