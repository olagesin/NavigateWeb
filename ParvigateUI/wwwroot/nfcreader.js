export function nfcreader() {

    window.readNFC = async (dotNetObj) => {
        try {
            // Perform NFC card reading operations here
            const cardId = await performNFCReading();

            // Invoke the UpdateNFCData method in the Blazor component
            await dotNetObj.invokeMethodAsync("UpdateNFCData", cardId);
        } catch (error) {
            console.error("Error reading NFC card:", error);
        }
    };

    async function performNFCReading() {
        //if (!("NDEFReader" in window)) {
        //    throw new Error("Web NFC API is not supported in this browser.");
        //}

        try {
            const ndef = new NDEFReader();

            await ndef.scan();

            const reading = await ndef.read();

            if (reading.records && reading.records.length > 0) {
                const record = reading.records[0];
                const cardId = record.data.text();
                return cardId;
            } else {
                throw new Error("No NFC records found on the card.");
            }
        } catch (error) {
            throw new Error(`Error reading NFC card: ${error.message}`);
        }
    }

    window.connectToDevice = async (device) => {
        try {
            // Perform the connection logic using the selected device
            // You can access the device properties (e.g., device.productName) to retrieve information about the selected device
            console.log('Connecting to device:', device);

            // Example: Connect to the NFC reader and read data
            const reader = new NDEFReader();
            await reader.scan();
            reader.addEventListener('reading', ({ message }) => {
                // Process the NDEF message
                console.log(message.records);
            });
        } catch (error) {
            console.error('Error connecting to device:', error);
        }
    };


    window.listConnectedDevices = async () => {
        const devices = await navigator.usb.getDevices();
        return devices;
    };

    return " ";
}