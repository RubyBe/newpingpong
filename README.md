# _Ping Pong with C#, Nancy, and Razor_

#### _Project Specifications_

#### By _**Sid Benavente**_

## Description/Specs

| Behavior        | Input Example           | Output Example  |
| ------------- |:-------------:| -----:|
| It can accept a number from a player  | 3 | 3 |
| It can generate a list of numbers from 1 through the number accepted from the player  | 5 | [1,2,3,4,5] |
| It can replace multiples of 3 with the string "ping"  | 3 | [1,2,"ping"] |
| It can replace multiples of 5 with the string "pong"  | 5 | [1,2,"ping",4,"pong"] |
| It can replace multiples of both 3 and 5 with the string "ping-pong"  | 15 | [...13,14,"ping-pong"] |
| It can set priority for multiples of (both 3 and 5) over multiples of (either 3) (or 5)  | 15 | [..."pong",11,"ping",13,14,"ping-pong"]

* Clone this repository, and on your pre-configured Epicodus computer, run "DNU restore" at the PowerShell prompt in the top directory of the cloned repository. Then type in "DNX Kestrel" at the same prompt and a local instance of the kestrel server will boot. Navigate in your browser to "LocalHost:5004" to view the homepage.

## Known Bugs

## Support and contact details
Please contact the authors if you have any questions or comments.

## Technologies Used
This webpage was written using C#, Nancy, Razor, CSS, and Bootstrap.

### License
Copyright (c) 2016 **_ Sid Benavente _**

This software is licensed under the MIT license.
