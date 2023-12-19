
class ShipReview extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            id: this.props.data.shipInfoId,
            name: this.props.data.name,
            imo: this.props.data.imo,
            type: this.props.data.type,
            flag: this.props.data.flag,
            dwt: this.props.data.dwt,
            length: this.props.data.length,
            grossTon: this.props.data.grossTon,
            beam: this.props.data.beam,
            draught: this.props.data.draught,
            photo: this.props.data.photo,
            buildYear: this.props.data.buildYear,
            owner: this.props.data.owner,
            manager: this.props.data.manager,
            vesselQualityValue: this.props.data.shipEvaluations[0].vesselQualityValue,
            crewPerformanceValue: this.props.data.shipEvaluations[0].crewPerformanceValue,
            crewAttitudeValue: this.props.data.shipEvaluations[0].crewAttitudeValue,
            fuelEfficiencyValue: this.props.data.shipEvaluations[0].fuelEfficiencyValue,
            safetyScoreValue: this.props.data.shipEvaluations[0].safetyScoreValue,
            saved: "",
            showConfirm: { display: "none" }
        };
        console.log(this.state.id);
    }
    render() {
        //var handleAddressChange = (newAddress) => {
        //    this.setState({ address: newAddress });
        //}
        var handleNameChange = (e) => {
            this.setState({ name: e.target.value });
        }
        var handleTypeChange = (e) => {
            this.setState({ type: e.target.value });
        }
        var handleImoChange = (e) => {
            this.setState({ imo: e.target.value });
        }

        var handleFlagChange = (e) => {
            this.setState({ flag: e.target.value });
        }

        var handleDwtChange = (e) => {
            this.setState({ dwt: e.target.value });
        }

        var handleLengthChange = (e) => {
            this.setState({ length: e.target.value });
        }

        var handleGrossTonChange = (e) => {
            this.setState({ grossTon: e.target.value });
        }

        var handleBeamChange = (e) => {
            this.setState({ beam: e.target.value });
        }

        var handleDraughtChange = (e) => {
            this.setState({ draught: e.target.value });
        }

        var handlePhotoChange = (e) => {
            this.setState({ photo: e.target.value });
        }

        var handleBuildYearChange = (e) => {
            this.setState({ buildYear: e.target.value });
        }

        var handleOwnerChange = (e) => {
            this.setState({ owner: e.target.value });
        }

        var handleManagerChange = (e) => {
            this.setState({ manager: e.target.value });
        }

        var handleVesselQualityValueChange = (e) => {
            this.setState({ vesselQualityValue: e.target.value });
        }

        var handleCrewPerformanceValueChange = (e) => {
            this.setState({ crewPerformanceValue: e.target.value });
        }

        var handleCrewAttitudeValueChange = (e) => {
            this.setState({ crewAttitudeValue: e.target.value });
        }

        var handleFuelEfficiencyValueChange = (e) => {
            this.setState({ fuelEfficiencyValue: e.target.value });
        }

        var handleSafetyScoreValueChange = (e) => {
            this.setState({ safetyScoreValue: e.target.value });
        }

        
        //var submitChange = () => {
        //    var shipInfo = {
        //        id: this.state.id,
        //        name: this.state.name,
        //        imo: this.state.imo,
        //        type: this.state.type,
        //        flag: this.state.flag,
        //        dwt: this.state.dwt,
        //        length: this.state.length,
        //        grossTon: this.state.grossTon,
        //        beam: this.state.beam,
        //        draught: this.state.draught,
        //        photo: this.state.photo,
        //        buildYear: this.state.buildYear,
        //        owner: this.state.owner,
        //        manager: this.state.manager,
        //        vesselQualityValue: this.state.vesselQualityValue,
        //        crewPerformanceValue: this.state.crewPerformanceValue,
        //        crewAttitudeValue: this.state.crewAttitudeValue,
        //        fuelEfficiencyValue: this.state.fuelEfficiencyValue,
        //        safetyScoreValue: this.state.safetyScoreValue

        //    };
        //    console.log(shipInfo);
        //    $.ajax({
        //        url: ShipReviewsURL,
        //        type: "PUT",
        //        data: JSON.stringify(shipInfo),
        //        contentType: "application/json",
        //        success: function (data) {
        //            console.log(data);
        //            this.setState({ showConfirm: { display: "inherit" } });
        //        }.bind(this),
        //        error: function (event, request, settings) {
        //            console.log(settings);
        //            console.log(event);
        //            console.log(request);
        //        }
        //    });
        //}




        ////
        return (
            
            <div className="row col-md-8">
                <div>
                    <CardComponent
                        cardData={{
                            id: this.state.id,
                            name: this.props.data.name,
                            imo: this.props.data.imo,
                            type: this.props.data.type,
                            flag: this.props.data.flag,
                            dwt: this.props.data.dwt,
                            length: this.props.data.length,
                            grossTon: this.props.data.grossTon,
                            beam: this.props.data.beam,
                            draught: this.props.data.draught,
                            photo: this.props.data.photo,
                            buildYear: this.props.data.buildYear,
                            owner: this.props.data.owner,
                            manager: this.props.data.manager,
                            vesselQualityValue: this.props.data.shipEvaluations[0].vesselQualityValue,
                            crewPerformanceValue: this.props.data.shipEvaluations[0].crewPerformanceValue,
                            crewAttitudeValue: this.props.data.shipEvaluations[0].crewAttitudeValue,
                            fuelEfficiencyValue: this.props.data.shipEvaluations[0].fuelEfficiencyValue,
                            safetyScoreValue: this.props.data.shipEvaluations[0].safetyScoreValue

                           
                        }}


                    />

                    
                </div>
                <br></br>
                <br></br>
                
            </div>

        );
        console.log(this.props.data.shipInfoId);
        console.log(this.cardData.id);
    }
}