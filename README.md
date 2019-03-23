# DotNetCoreAPIMySQL - A .Net Core API only application with MySQL

A very basic .NetCore application using MySQL as database with two controllers:

<h2>1. ValuesController (without SQL):- </h2><br>
https://localhost:5001/api/values <br>

The result is:-
["Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"] <br>

https://localhost:5001/api/values/3<br>
The result is:- <br>
Wednesday

<br><br>


<h2>2. DaysController (with My SQL Database): - </h2>
https://localhost:5001/api/values <br>
The result is:- <br>
[{"id":1,"dayName":"Sunday"},{"id":2,"dayName":"Monday"},{"id":3,"dayName":"Tuesday"},{"id":4,"dayName":"Wednesday"},{"id":5,"dayName":"Thursday"},{"id":6,"dayName":"Friday"},{"id":7,"dayName":"Saturday"}]
<br>

https://localhost:5001/api/values/3 <br>
The result is:-<br>
{"id":3,"dayName":"Tuesday"}

