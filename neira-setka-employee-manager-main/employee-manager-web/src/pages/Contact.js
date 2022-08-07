import H3 from '@material-tailwind/react/Heading3';
import Paragraph from '@material-tailwind/react/Paragraph';
import Input from '@material-tailwind/react/Input';
import Textarea from '@material-tailwind/react/Textarea';
import Button from '@material-tailwind/react/Button';
import React,{useState} from 'react';
import {createContactUs} from "services/ContactUsService";

export default function Form() {
    const [name,setName]=useState();
    const [email,setEmail]=useState();
    const [phone,setPhone]=useState();

        function handleNameChange(event)
        {
            console.log(event);
            setName(event.target.value);
        }

        function handleEmailChange(event)
        {
            console.log(event);
            setEmail(event.target.value);
        }

        function handlePhoneChange(event)
        {
            console.log(event);
            setPhone(event.target.value);
        }
        
        async function handleSubmit(event)
        {
        try
        {
            event.preventDefault();
            const createContactUsMessage={name:name, email:email, phone:phone};
            const response = await createContactUs(createContactUsMessage);
            console.log(response);
            alert("Your message is correct!");
        }
        catch(error)
        {
            console.log(error);
            alert("Your message is not correct!");
        }
    }
       
    return (
        <div className="flex flex-wrap justify-center mt-24">
            <div className="w-full lg:w-8/12 px-4">
                <div className="relative flex flex-col min-w-0 break-words w-full mb-6">
                    <div className="flex-auto p-5 lg:p-10">
                        <div className="w-full text-center">
                            <H3 color="gray">Contact Us</H3>
                            <Paragraph color="blueGray">
                            </Paragraph>
                        </div>
                        <form onSubmit={handleSubmit}>
                            <div className="flex gap-8 mt-16 mb-12">
                                <Input
                                    type="text"
                                    placeholder="Your Name"
                                    color="lightBlue"
                                    name="name"
                                    onChange={handleNameChange}
                                />
                                <Input
                                    type="email"
                                    placeholder="Your Email"
                                    color="lightBlue"
                                    name="email"
                                    onChange={handleEmailChange}
                                />
                                 <Input
                                    type="phone"
                                    placeholder="Your Phone"
                                    color="lightBlue"
                                    name="phone"
                                    onChange={handlePhoneChange}
                                    />
                            </div>

                            <Textarea color="lightBlue" placeholder="Message" />

                            <div className="flex justify-center mt-10">
                                <Button color="lightBlue" ripple="light" >
                                    Send Message
                                </Button>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    );
}