
export const foo = (target: any, propertyKey: string, descriptor: PropertyDescriptor) => {
    const originalMethod = descriptor.value;
    descriptor.value = function (...args: any[]) {
        let msg: string;
        if(args[0]){
            msg = (`${propertyKey}, that has a parameter value: ${args[0]}`)
        }
        else{
            msg = `${propertyKey}`
        }
        console.log(`Logger says - calling the method: ${msg}`);
        const result = originalMethod.apply(this, args);
        if(result){
            msg = `${propertyKey} and returned: ${JSON.stringify(result)}`;
        }
        else{
            msg = `${propertyKey}`;
        }
        console.log(`Logger says - called the method: ${msg}`);
        return result;
    };
    return descriptor;
};
