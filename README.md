<link rel="canonical" href="https://levelup.gitconnected.com/how-to-cancel-a-running-process-in-a-separate-request-command-in-net-c-2ca8fb733618?sk=80400e81d5921ea2ae97e3220d01befb" />

# How to Cancel a Running Process in a Separate Request/Command in .NET C#
### Learn how to cancel an already running process in a separate request in .NET C#

<p align="center">
  <img src="https://miro.medium.com/max/2000/1*OBVFMB5U2OFShVOJ_AQVpA.jpeg">
</p>

<br/>

<p>
One of my friends was working on a unique project where he needed to be able to cancel a long running process but on a separate request. Weird? maybe but it happened. Let me tell you more…
</p>

<p>
He was working on a Web Application with heavy 3D modelling. This application was supposed to be used for building 3D models for a certain product and the end user at some point should have been able to download this model in a certain format.
</p>

<p>
However, the modeling process itself is so heavy and requires a lot of processing. That’s why the end user was supposed to provide some input, trigger the modelling process and at some point he was supposed to get an email when the model is ready for download.
</p>

<p>
Up till now, it’s ok. But, if the end user decides to apply some changes on the inputs, he can start a new modelling process, but what about the already running one? Is it wise to just keep it running on the server???
</p>

<br/>

If you are interested into reading more about this topic, you can read [the rest of the article][Article]. 

<br/>

## If you want to support me:
▶ Subscribe to Medium using [my referral link][Membership]<br/>
▶ Subscribe to [Medium Newsletter][Subscribe]<br/>
▶ Subscribe to [LinkedIn Newsletter][Newsletter]<br/>
▶ Follow me on [Medium][Blog]<br/>
▶ Follow me on [Twitter][Twitter]<br/>
▶ Follow me on [LinkedIn][LinkedIn]

<br/>

## Authors:
* [Ahmed Tarek Hasan]


[Ahmed Tarek Hasan]: https://medium.com/@eng_ahmed.tarek
[Blog]: https://medium.com/@eng_ahmed.tarek
[Membership]: https://medium.com/@eng_ahmed.tarek/membership
[Subscribe]: https://medium.com/subscribe/@eng_ahmed.tarek
[Twitter]: https://twitter.com/AhmedTarekHasa1
[LinkedIn]: https://www.linkedin.com/in/atarekhasan/
[Friend Links]: https://www.linkedin.com/feed/update/urn:li:activity:6866082670108143616/
[Newsletter]: https://www.linkedin.com/newsletters/development-simply-put-6866647119655247872/
[Article]: https://levelup.gitconnected.com/how-to-cancel-a-running-process-in-a-separate-request-command-in-net-c-2ca8fb733618?sk=80400e81d5921ea2ae97e3220d01befb
