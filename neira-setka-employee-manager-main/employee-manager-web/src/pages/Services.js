import Title from 'components/landing/Title';
import ContactCard from 'components/landing/ContactCard';
import DefaultNavbar from 'components/DefaultNavbar';

export default function Services() {
return (
        
    <div className=" bg-profile-background bg-cover bg-center absolute top-0 w-full h-full" >
        { /*<section className="pb-20 relative block bg-gray-100"> */}
            <div className="container max-w-7xl mx-auto px-4 lg:pt-24 ">
            <DefaultNavbar/>
                <Title heading="Services"></Title>
                
                <div className="flex flex-wrap -mt-12 justify-center">
                    <ContactCard icon="circle" title="WEB APPLICATIONS">
                    A web application (or web app) is application software that runs on a web server, 
                    unlike computer-based software programs that are run locally on the operating system (OS) of the device.
                    </ContactCard>
                    <ContactCard icon="lock" title="CYBER SECURITY">
                    Cyber security is the practice of defending computers, servers, mobile devices, electronic systems, networks, and data from malicious attacks.
                    </ContactCard>
                    <ContactCard icon="phone" title="MOBILE FIRST">
                    “Mobile first”, as the name suggests, means that we start the product design from the mobile end which has more restrictions, 
                    then expand its features to create a tablet or desktop version.
                    </ContactCard>
                </div>
 
            </div>
        { /*</section> */}
   </div>
    );
}