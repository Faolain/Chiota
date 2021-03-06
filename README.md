# Chiota
Chiota is an [IOTA](http://iota.org/) [Xamarin](https://www.xamarin.com/) Chat App based on [Felandils C# .NET Port of the IOTA lib](https://github.com/Felandil/tangle-.net), who also helped with this app, [Steppenwolfe65 NTRU-NET](https://github.com/Steppenwolfe65/NTRU-NET) and [jamesmontemagnos MonkeyChat](https://github.com/jamesmontemagno/app-monkeychat).  

The goal is to create a quantum secure chat app, in which you are the owner of your own data and nobody else! 

Impressions of the current state:

<img src="https://chiota.blob.core.windows.net/screenshots/Screenshot_20180326-123335.jpg" width="200"> <img src="https://chiota.blob.core.windows.net/screenshots/Screenshot_20180312-161520.jpg" width="200"> <img src="https://chiota.blob.core.windows.net/screenshots/chiotaDesktop.png" width="200">

# How Chiota works?
Currently, Chiota doesn’t use the MAM Layer for sending secure messages. Instead, it uses the NTRU Encryption. 
There are several reasons for that:
-	NTRU or some other form of key exchange is needed for the MAM-Layer anyway
-	For the MAM Layer, you have a lot of different transactions and currently, the proof-of-work takes really long, so the goal is to reduce the number of necessary transactions
-	You need to store the state of the MAM Layer (root hash, channel keys, etc.). If you want to store these things quantum secure on the tangle it results in more messages and therefore additional PoW

The disadvantage of the current system:
-	You are limited to 106 characters per transaction because the NTRU encryption needs more space 
-	Advances in cryptanalysis may at some point break NTRU

# Motivation
During the process of creating the health care chatbot Florence, we found out that we can't use the technology to its full potential due to various problems with the current state of the healthcare system. **You as a patient should be in control of your healthcare data and a chatbot should support the private, secure and continuous communication between you and your healthcare provider network.** However, with the current technology that isn't possible. That is why we started to experiment with Iota. So, we have a huge interest in improving the technology for sharing data with the help of the tangle.

# About us/me
My name is David Hawig and I am the developer of Florence.chat. In May I will stop working at my current (secure) job and cofound a company (to do something meaningful) whose goal is to leverage Florence to support the communication between patients and healthcare providers. You can contact me on [linkedin](https://www.linkedin.com/in/david-hawig-206a44b1/) or via Mail (david.hawig[at]florence[dot]chat).

We welcome any kind of help or contribution!

# To-do/Contribute
Currently, there are the following points on my to-do list:
- [x] Store contacts/profile on the tangle
- [ ] Faster POW, Adress generation
- [ ] Check for unique Address public key combination
- [ ] Mam Integration
- [ ] Improve/check implemented NTRU solution for key exchange
- [ ] iOS App
- [ ] improve Windows App
- [ ] Notifications (https://github.com/edsnider/LocalNotificationsPlugin)
- [ ] Pictures of adress or qr codes
- [ ] Unit testing


# Donate
```
GUEOJUOWOWYEXYLZXNQUYMLMETF9OOGASSKUZZWUJNMSHLFLYIDIVKXKLTLZPMNNJCYVSRZABFKCAVVIW9IYHJNNRX 
```
