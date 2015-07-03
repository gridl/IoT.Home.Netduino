Home
====

##Home Intelligence

###Define your startup in one sentence:

1. hardware basic product type
2. problem it solves
3. ideal customers

###MVP: minimum viable product

Hardware by nature is comprised of “chunky” stages: design, prototype, manufacture, deploy.

1. how difficult is to build prototype?
2. how long will it take?
3. focus on getting it into users' hands ASAP

###Customer discovery

Customer discovery is a way of improving a product’s success by developing a better understanding of the consumers. Talk to customers and learn if your business is a good idea when everyone is lying to you.

This stage is important for every startup. You want to do this ground work now so that you can secure as much as you can your product’s success ($$$) once it’s shipped. It also touches on many other facets of building a startup, like growing a mailing list pre-launch, and having access to direct market research. **Once you’re at the beta stage with your prototype, you’ll be very glad to have a pool of consumers who can provide real feedback for final fixes and tweaks**.

The first thing you need to ask **yourself** is whether you are a customer of your company. Are you personally familiar with the problem that your product is fixing? If you weren’t building this product and came across it in a store, would you buy it and use it? This is your ideal square one.
  
- Avoid pitching: Don’t mention your idea, or what your product is today.
- Ask about specifics of their past and present experience, and not generic opinions about how they would act in the future.
- They should be talking (and you should be listening) 90% of the time.
- Deflect compliments: Compliments are fool’s gold. People are simply nice and they don’t want to hurt your feelings.  Compliments are all worthless, until they are validated. Only facts and commitments have worth. 
- Dig beneath ideas: People will ask for features: “Do you do X?” Always follow this by asking why they want this, how they are coping now, why it matters. Deeply understand their motivations. They will reveal their ultimate goal and how important it is to their buying decision.
- Let them show you their mental model of the world. Don’t correct them or dictate how it looks for you. Even if you have an answer to one of their concerns or objectives, let them talk because you are getting valuable insight into how your customer thinks.
- Ask at least one question that can change or invalidate your whole business. This is your “terrifying question”.
- Learn to love bad news.

#####How to know if it’s working

In addition to obvious good signs like pre-selling before building, there are other signs of a good, valuable meeting:  

- Facts. Concrete, specific facts about what they do and why.  
- Commitment. They are demonstrating their seriousness by giving up more time (another meeting), risking reputation (an introduction to someone else), money (pre-sale), or requesting more info (growing mailing list).

#####How to know if it’s NOT working

- If all you come back with are compliments like, “They love our vision”, or “they’re really excited”. These are not facts.
- People are saying “yes” a lot but are not paying or committing in an way
- You weren’t scared of any of the questions you asked.
- The responses you get from 20 conversations are all over the place. This indicates your market segment is too broad and you need to focus on your buyer persona more.

###The cardboard prototype

Delivering something to the user as soon as possible is a valuable move for startups. For hardware, this means not being afraid of presenting an “ugly” prototype. As long as it shows what it can do, it could be made out of cardboard with wires hanging off of it. Entrepreneurs tend to hesitate when it comes to sharing their product while its in development, or default to assuming that they need more polish for fear of causing a bad first impression. This is a critical error. Evolve your product in parallel with real customer feedback.

![Hardware Lifecycle](https://upverter.com/static/newsletter/lifecycle.jpg)

###Landing Page + Mailing List

A landing page, in some ways, is a variation on your minimum viable product (MVP). Instead of offering a physical V01 of your prototype that people can play around with in their hands, you’re essentially illustrating the idea of your product with copy and a domain name. A landing page can help you gauge the general interest of the market in your hardware device and serve as a litmus test on whether or not the problem you are solving is one that actually resonates with customers.

Another incredibly huge gain from building a landing page is your mailing list. This is critical because when you eventually launch, you’re going to need to have a small subset of evangelists that can help you promote your message and product. The people on your mailing is your very first Kickstarter pledges, your first Tweeters, your first user group, and your first customers. You’ll be able to call on them when you need help with a final design decision, and gain insight from when you need to find that sweet spot with pricing.

It’s not necessary to spend weeks on your landing page. Decide on a clickable, shareable domain name, put together something on a website builder like Squarespace, and jam in your Elevator Pitch. Do use high-quality images. Do not use Comic Sans. Build it and ship it. When you get into conversation with people, point them to it and start collecting those valuable email addresses!

###Hardware Product Canvas

All hardware is made up of parts, and those parts fit into a very small group of roles. There are sensors, communication, storage, user interfaces, and processing. We just need to make it easier for people to talk about what’s in their product. We just needed to break it up, and give people a way to write it down.

This is the Hardware Product Canvas. It’s a tool designed to help you get through the earliest stages of a hardware design. It’s open-source, creative commons, and totally hackable. 

![Hardware Product Canvas](http://i.imgur.com/WEfsNcC.png)

#####How To Use It?

To use the canvas you just need to fill in the blanks. What kind of forces does your product need to sense? What kind of communication do you need? Do you need to store anything on the device? How much data do you need to process, and what kind of processor do you need? Do you need a user interface? LEDs or LCD or something else?

#####Building Block: Sensors

Sensors are components that measure forces in the physical world. They are good for measuring or detecting light (optical light sensor), or movement (accelerometer), or sound (microphone). Sensors are very popular recently in internet-of-things, and quantified-self devices for their ability to take previously offline data and bring it online. 

#####Building Block: Communication

Communication are components that send and receive signals between devices. They are good for getting data onto and off of your product.

#####Building Block: Storage

Storage are components that hold data. They are good for remembering the things your device senses or the things that are communicated to it. The most common storage these days is small flash memory ICs connected directly to the PCB in a device. 

#####Building Block: User Interface & Experience

User Interfaces are components that allow the user to enter information, or components that display information back to the user. They are great for turning things on and off (switch), changing settings (push button), displaying what mode a device is in (LCD), showing power status (LED), etc. 

#####Building Block: Processing

Processing are the central components in most devices. They are the brain of your product. They get data from sensors, send and receive through the communication components, write data to the storage components, receive user input and display back user information.

#####Building Block: What About Everything Else?

There are some components, like those that connect to mechanical elements, that don’t fit perfectly into the above 5 roles. Motors, relays and servos are good examples of this - they are similar to user interfaces, but they often manipulate the physical world because of a decision the processor has made. These kind of elements don’t have a great place in the canvas (yet!) so for now we recommend putting them in the User Interface or Storage sections.

![hardware_product_canvas-example](http://i.imgur.com/B22Qr2i.png)

###what’s an ideal part?

An ideal part can be loosely defined as one that:

- Performs the required function at the required performance and quality
- Has an interface that is compatible with the other relevant components in the design (ie: uses the same protocol, runs at the same frequency, same data width, etc.)
- Has power requirements (ie: voltage and current) that can be met by the power system and are similar to the power requirements of other components in the design (ie: runs on the same voltage)
- Has a small package and is conducive to a clean layout
- Is in stock and widely available with acceptable lead times
- Is low cost in accordance with your budget

#####Cast a WIDE net and find all your vendors

The first, most basic step would be to find all your vendors. For a given kind of part (ie: a BluetoothLE chip, LED driver, LiPo battery charger), find all the companies that play in that space.  A great way to do this is through a combination of Google and distributor websites (like [Digikey](http://www.digikey.com/ "Digikey"), [Avnet](http://www.avnet.com/ "Avnet"), [Arrow](http://www.arrow.com/ "Arrow"), [Newark](http://www.newark.com/ "Newark"), [Mouser](http://www.mouser.com/ "Mouser"), etc.).  Simply search for the kind of part you’re looking for and make a note of all the vendors that manufacture components in that area.

#####Generate a list of part candidates

Visit each vendor’s website and use their parametric search to find potential candidates. From the results, make a note of parts that look like they might work based on their titles, descriptions, and parameters. Prefer to use the vendor website rather than some other parts search engine because I can trust that their list of parts is up-to-date and comprehensive. Narrow down the list to limit the search to parts that are currently in stock on distributor websites. This works when building prototypes ASAP, and avoid waiting a few weeks for lead times in a phase that is acceptable spending more money on parts. 

#####Trim to a shortlist 

Quickly visit the product page of each part and skim through its feature list, while keeping the “ideal criteria” in mind to see if there are any glaring things that disqualify this part.  You’ll find them fast.  Most of the ideal criteria are typically listed in these product pages. This should distill your long list of parts to a qualified shortlist pretty quickly.

#####Do a lot of reading  (it’ll pay off)

At this point, you should have a small list of parts that look like good candidates.  The next step is to read the datasheet of each part to see if it meets your criteria.  Datasheets can be long and everyone hates reading them. It’s tempting to rush through this step but it’s one of the most important stages of the whole process.  Time and time again, I see people making design errors or spending hours on debugging, simply because they didn’t sit down and read the datasheet slowly.  

#####Iterate: Rinse and repeat

As you learn about available parts, you may discover new constraints.  For example, the candidate parts may only support an interface that your processor doesn’t.  In this case, you have to find a new processor or change your design.  Or you may find an ideal part but its required power rail voltage is different than all the other parts on your board.  Expect to iterate on your entire part search and change other parts of the design to accommodate them.
