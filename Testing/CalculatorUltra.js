//We may want to break this up into seperate js files.  We may also want to set it up as a class instead of loose functions.

//global variables
//Variables for getting room dimensions.
var roomX, roomY, roomZ;
//Variables for the paint and floor area.
var paintArea, floorArea;
//Variables for paint information. **paintPrice should be gotten from our price database**
var paintPrice, paintCoverage, paintTotalPrice, paintCans;
//Variables for flooring.
var floorPrice, floorTotalPrice;
//Variables for roofing.  **ShinglePrice should be gotten from the database**
var roofRise, roofRun, roofPitch, roofArea, roofX, roofY, shingleCoverage, shinglePrice, shingleBundles, totalRoofPrice;


//function for calculator
//Calculates the square footage of the room
function calculateRoomArea(roomX, roomY, roomZ) {
    paintArea = ((roomX * roomZ) * 2) + ((roomY * roomZ) * 2) + (roomX * roomY);
    floorArea = (roomX * roomY);
}

//Calculates the paint price for a room.
function calculatePaintPrice(paintArea, paintPrice) {
    paintCans = Math.ceil(paintArea / paintCoverage);
    paintTotalPrice = paintCans * paintPrice;
    paintTotalPrice.toFixed(2);
}

//calculates the floor price for a room.
function calculateFloorPrice(floorArea, floorPrice) {
    floorTotalPrice = floorArea * floorPrice;
    floorTotalPrice.toFixed(2);
}

//calculates the pitch of the roof based off the rise and run, mostly used as an internal number... doesn't need to be visable to the user.
function calculateRoofPitch(roofRise, roofRun) {
    roofPitch = 1 + Math.sqrt(roofRise ^ 2 + roofRun ^ 2) / 12;
}

//Calculates the area for the roof, and the amount of shingles needed.
function calculateRoof(roofX, roofY, roofPitch) {
    roofArea = roofX * roofY * roofPitch;
    shingleBundles = Math.ceil(roofArea / shingleCoverage);
}

//Calculates the total roof price.
function calculateRoofPrice(shingleBundles, shinglePrice) {
    totalRoofPrice = shingleBundles * shinglePrice;
    totalRoofPrice.toFixed(2);
}